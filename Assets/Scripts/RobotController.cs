using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    [SerializeField] GameObject shoot;
    [SerializeField] float shootDelay;
    [SerializeField] float shootProb;
    [SerializeField] AudioClip sfxShoot;

    public float speed = 3f; // Velocidad del robot
    private int direction = 1; // Direcci�n del movimiento: 1 para derecha, -1 para izquierda

    private void Start()
    {
        StartCoroutine("Shoot");
    }
    void Update()
    {
        // Movimiento del robot
        transform.Translate(Vector2.right * direction * speed * Time.deltaTime);
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        // Si el robot choca con el terreno (Terrain), cambiamos su direcci�n
        if (other.gameObject.CompareTag("Terrain"))
        {
            direction *= -1; // Cambiamos la direcci�n del movimiento
        }
    }
    IEnumerator Shoot()
    {
        Debug.Log("Corrutina de disparo iniciada"); 
        while (true)
        {
            yield return new WaitForSeconds(shootDelay); // Esperar un tiempo determinado antes de continuar con la corutina

            // Verificar si el disparo debe ocurrir seg�n la probabilidad establecida
            if (Random.Range(0f, 1f) < shootProb)
            {
                // Instanciar el disparo en la posici�n del robot y a�adirle sonido
                Instantiate(shoot, transform.position, Quaternion.identity);
                AudioSource.PlayClipAtPoint(sfxShoot, Camera.main.transform.position);

                Debug.Log("Corrutina de disparo en proceso"); 
            }
        }
    }
}
