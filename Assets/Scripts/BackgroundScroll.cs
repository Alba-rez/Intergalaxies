using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    [SerializeField] float speed;
    float heigth;

    void Start()
    {
        heigth = GetComponent<SpriteRenderer>().bounds.size.y; // con esto extraemos la altura de la imagen 
    }

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y < -heigth)
        {
            transform.Translate(Vector3.up * 2 * heigth); // quiere saltar el doble de la altura
        }

    }


}
