using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame00 : MonoBehaviour
{
   

    [SerializeField] Text msg1;
    [SerializeField] Text msg2;
    [SerializeField] AudioClip sfx;
    [SerializeField] float delayBeforeNextMessage;

    private bool gameStarted = false;

    void Start()
    {
      
    }

    void Update()
    {
        if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.Escape) &&!gameStarted)
        {
            AudioSource.PlayClipAtPoint(sfx, Camera.main.transform.position);
            gameStarted = true;          
            StartCoroutine(StartNextLevel());
        }
        if(Input.GetKeyDown(KeyCode.Escape) )
            {
            msg1.enabled = false;
            msg2.enabled = false;
            Application.Quit();
            
           
        }
    }

    IEnumerator StartNextLevel()
    {
        yield return new WaitForSeconds(delayBeforeNextMessage);
        SceneManager.LoadScene(2);
    }
}



