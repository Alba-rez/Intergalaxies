using UnityEngine;
using UnityEngine.SceneManagement;

public class TakeOff : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] AudioClip sfxTakeOff;
    GameManager manager;
    GameObject player;

    void Awake()
    {
        // Recuperar la referencia al GameManager
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();

        // Recuperar referencia al jugador
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && manager != null)
        {
            // Comprobar si el jugador ha atravesado la nave y si los puntos son suficientes
            if (manager.getScore() >= 500)
            {
                anim.SetTrigger("takeOff");
                player.SetActive(false);
                AudioSource.PlayClipAtPoint(sfxTakeOff, Camera.main.transform.position);
                Invoke("NextLevel", 2);
            }
        }
    }

    void NextLevel()
    {
        int nextId = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextId < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextId);
        }
        else
        {
            // Si es la última escena, cargar la primera
            SceneManager.LoadScene(0);
        }
    }
}
