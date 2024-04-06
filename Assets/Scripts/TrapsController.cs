using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapsController : MonoBehaviour
{
    [SerializeField] AudioClip clip;
    //GameManager Score;

    void restPoints()
    {
        GameManager.GetInstance().AddScore(gameObject.tag);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (GameManager.GetInstance().getScore() >=50) {

            if (collision.gameObject.tag == "Player")
            {
                restPoints();
                AudioSource.PlayClipAtPoint(clip, gameObject.transform.position);
            }
        }
        
    }
}
