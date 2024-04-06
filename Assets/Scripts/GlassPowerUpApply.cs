using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalassPowerUpApply : MonoBehaviour
{
    [SerializeField] AudioClip clip;
    GameManager Score;
    

    void DestroyGlass()
    {
        GameManager.GetInstance().AddScore(gameObject.tag);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
            DestroyGlass();
        }
    }
}
