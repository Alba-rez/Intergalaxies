using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ShootController : MonoBehaviour
{
    
    [SerializeField] float speed;
    [SerializeField] float temp;
    GameManager gmanager;

    void Start()
    {
        gmanager = GameManager.GetInstance();
    }

    // Update is called once per frame
    void Update()
    {
        // actualizamos temporizador 
        temp -= Time.deltaTime;
        if (temp < 0)
        {
            Destroy(gameObject);
        }

        //actualizaremos la posición
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);

        if (other.gameObject.tag == "Player") 
        {
            gmanager.LoseLive();
            //Debug.Log("auchh");
            
        }
        

    }


        
    }


