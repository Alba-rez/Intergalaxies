using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    AudioSource sfxTyping;
    

    [SerializeField] Text msg1;
    [SerializeField] Text msg2;
    [SerializeField] Text msg3;
    [SerializeField] Text msg4;
    [SerializeField] float typingSpeed;
    [SerializeField] float delayBeforeNextMessage;
    [SerializeField] float msg1DisplayTime;
    [SerializeField] AudioClip sfx;
    

    private bool message1Complete = false;
    private bool message2Complete = false;
    private bool message3Complete = false;
    private bool message4Complete = false;
    private bool gameStarted = false;

    void Start()
    {
        
        msg2.enabled = false;
        msg3.enabled = false;
        msg4.enabled = false;
        StartCoroutine(TypeMessage(msg1));
        sfxTyping = GetComponent<AudioSource>();




    }

    void Update()
    {
        if (message2Complete && Input.anyKeyDown && !Input.GetKeyDown(KeyCode.Escape) && !Input.GetKeyDown(KeyCode.Space) && !gameStarted)
        {
            AudioSource.PlayClipAtPoint(sfx, Camera.main.transform.position);
            msg2.enabled = false;
            msg3.enabled = false;
            msg4.enabled = false;
            gameStarted = true;          
            StartCoroutine(StartNextLevel());
        }
        if (message2Complete && Input.GetKeyDown(KeyCode.Space) && !Input.GetKeyDown(KeyCode.Escape) && !gameStarted)
        {
            SceneManager.LoadScene(1);
        }
            if (message2Complete && message3Complete  && message4Complete && Input.GetKeyDown(KeyCode.Escape) )
            {
            msg2.enabled = false;
            msg3.enabled = false;
            msg4.enabled = false;
            Application.Quit();
            
           
        }
    }

    IEnumerator TypeMessage(Text messageText)
    {
        string originalText = messageText.text;
        messageText.text = "";

        foreach (char letter in originalText)
        {

            messageText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
            

        }

        if (messageText == msg1)
        {
            yield return new WaitForSeconds(msg1DisplayTime);
            messageText.enabled = false; // Desactivar el primer texto
            message1Complete = true; // Marcar el primer mensaje como completo
            StartCoroutine(TypeMessage(msg2)); // Iniciar la escritura del segundo mensaje
            msg2.enabled = true;
            StartCoroutine(TypeMessage(msg3)); // Iniciar la escritura del tercer mensaje
            msg3.enabled = true;
            StartCoroutine(TypeMessage(msg4)); // Iniciar la escritura del cuarto mensaje
            msg4.enabled = true;

        }
        else if (messageText == msg2)
        {
            message2Complete = true; // Marcar el segundo mensaje como completo
            
        }
        else if (messageText == msg3)
        {
            message3Complete = true; // Marcar el tercer mensaje como completo

        }
        else if (messageText == msg4)
        {
            message4Complete = true; // Marcar el cuarto mensaje como completo

        }


    }

    IEnumerator StartNextLevel()
    {
        yield return new WaitForSeconds(delayBeforeNextMessage);
        SceneManager.LoadScene(2);
    }
}



