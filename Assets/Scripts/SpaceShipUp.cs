using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipUp : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float force;
    [SerializeField] Vector3 endPosition;
    [SerializeField] float duration;


    bool active;

    void Start()
    {

        StartCoroutine("StartPlayer");
    }


    void FixedUpdate()
    {
        if (active)
        {
            CheckMove();
        }

    }

    private void CheckMove()
    {
        Vector2 direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        direction.Normalize();

        // aplicamos una fuerza en esa direcci�n 
        rb.AddForce(direction * force, ForceMode2D.Impulse);
    }

    IEnumerator StartPlayer()
    {
        Collider2D collider = GetComponent<Collider2D>();
        collider.enabled = false;
        Vector3 initialPosition = transform.position;
        float t = 0;
        while (t < duration)
        {
            t += Time.deltaTime;
            Vector3 newPosition = Vector3.Lerp(initialPosition, endPosition, t / duration);
            transform.position = newPosition;
            yield return null;

        }


    }


}
