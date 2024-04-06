using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPowerUpApply : MonoBehaviour
{
    [SerializeField] AudioClip clip;
    [SerializeField] GameObject dustExpl;
     GameManager Score;


    void DestroyBox()
    {
        GameManager.GetInstance().AddScore(gameObject.tag);
        Instantiate(dustExpl, transform.position, Quaternion.identity);
       
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {

            AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
          
            
            DestroyBox();
           

        }
    }
}
