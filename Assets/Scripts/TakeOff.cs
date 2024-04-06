using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TakeOff : MonoBehaviour
{
    
    [SerializeField] Animator anim;
    [SerializeField] GameManager manager;
    [SerializeField] GameObject player;
    [SerializeField] AudioClip sfxTakeOff;
    //int delay = 3;
    int sceneId;


    private void Start()
    {
        sceneId = SceneManager.GetActiveScene().buildIndex;
    }

    private void OnTriggerEnter2D(Collider2D other)

    {
        if (other.gameObject.tag == "Player" )
        {
          
            // Comprobar si el jugador ha atravesado la nave y si los puntos son 500
            if (manager.getScore() >= 50)
            {
                anim.SetTrigger("takeOff");
                player.SetActive(false);
                AudioSource.PlayClipAtPoint(sfxTakeOff, Camera.main.transform.position);
                Invoke("NextLevel",2);
            }
        }

    }
    void NextLevel()
    {
        int nextId = sceneId + 1;
        //yield return new WaitForSeconds(delay);
        
        if (sceneId==2) 
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(nextId);
        }
    }
}
