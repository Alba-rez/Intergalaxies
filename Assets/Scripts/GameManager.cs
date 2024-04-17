using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] Text txtScore;
    [SerializeField] Text txtMessage;
    [SerializeField] Image[] imgLives;
    [SerializeField] AudioClip sfxGameOver;
    

    const int SCORE_BOX = 50;
    const int REST_SCORE = -50;
    const int SCORE_GLASS = 60;
    const int LIVES = 3;
    int lives = LIVES;

    private int score;
    int sceneId;
    bool gameover;
    bool paused = false;

    // Referencias a las imágenes
    Image[] imgLivesRefs;



    public static GameManager GetInstance()
    {
        return instance;
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);



        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

       
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        txtScore = GameObject.Find("Score").GetComponent<Text>();
        txtMessage = GameObject.Find("Message").GetComponent<Text>();
        score = 0; // Aquí reinicio el score a 0
        gameover = false;

        if (scene.buildIndex == 1)
        {
            lives = LIVES;
            // Guardar el nuevo valor de vidas en PlayerPrefs
            for (int i = 0; i < LIVES; i++)
            {
                string lifeName = "Life" + (i + 1);
                PlayerPrefs.SetInt(lifeName, lives);
            }
        }
        
            imgLivesRefs = new Image[LIVES]; // Usa LIVES como la longitud del array
            for (int i = 0; i < LIVES; i++)
            {
                string lifeName = "Life" + (i + 1); // Genera el nombre de la vida
                GameObject lifeObject = GameObject.Find(lifeName); // Busca el GameObject con ese nombre
                if (lifeObject != null)
                {
                    imgLivesRefs[i] = lifeObject.GetComponent<Image>(); // Obtiene el componente Image
                }
            }
        if (scene.buildIndex != 0)
        {
            sceneId = scene.buildIndex;
        }



        OnGUI();
    }

    void Start()
    {
        sceneId = SceneManager.GetActiveScene().buildIndex;
        for (int i = 0; i < LIVES; i++)
        {
            string lifeName = "Life" + (i + 1);
            lives = PlayerPrefs.GetInt(lifeName, LIVES);
        }
    }

    public void AddScore(string tag)
    {
        int pts = 0;

        switch (tag)
        {
            case "Box":
                pts = SCORE_BOX;
                break;
            case "Traps":
                pts = REST_SCORE;
                break;
            case "Glass":
                pts = SCORE_GLASS;
                break;
                //añadiremos diamantes para obtener puntos

        }
        score += pts;
        OnGUI();


    }
    public int getScore()
    {
        return score;
    }



    public int getLives()
    {
        return lives;
    }
    public bool isGameOver()
    {
        return gameover;
    }


    public bool isGamePaused()
    {
        return paused;
    }


    // falta implementar condición Trigger pérdida de vidas para usar este método
    public void LoseLive()
    {
        lives--;
        
        if (lives == 0)
        {
            GameOver();
        }
        else
        {
            for (int i = 0; i < LIVES; i++)
            {
                string lifeName = "Life" + (i + 1);
                PlayerPrefs.SetInt(lifeName, lives); // Guardar las vidas restantes en PlayerPrefs           
            }
            PlayerPrefs.Save();

            OnGUI();
        }
    }

    void GameOver()
    {
        gameover = true;
        Time.timeScale = 1;
        AudioSource.PlayClipAtPoint(sfxGameOver, new Vector3(0, 0, -10), 1);
        txtMessage.text = "GAME OVER \n PRESS <RET> TO START";
    }



    private void OnGUI()
    {
        

        if (txtScore != null)
            txtScore.text = string.Format("{0,3:D3}", score);

        if (txtMessage != null)
        {
            if (gameover)
                txtMessage.text = "GAME OVER \n PRESS <RET> TO START";
            else if (paused)
                txtMessage.text = "PAUSED \nPRESS <P> TO RESUME";
            else
                txtMessage.text = "";
        }

        if (imgLivesRefs == null)
        {
            imgLivesRefs = new Image[imgLives.Length];

            for (int i = 0; i < imgLives.Length; i++)
            {
                imgLivesRefs[i] = imgLives[i];
            }
        }

        for (int i = 0; i < imgLivesRefs.Length; i++)
        {
            if (imgLivesRefs[i] != null)
                imgLivesRefs[i].enabled = i < lives;
        }



    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        else if (!gameover)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                if (paused)
                {
                    ResumeGame();
                }
                else
                {
                    PauseGame();
                }
            }



        }
        if (gameover && Input.GetKeyUp(KeyCode.Return))
        {
            // Reiniciar el número de vidas a 3     
            lives = LIVES;
            txtMessage.text = "";

            // Guardar el nuevo valor de vidas en PlayerPrefs
            for (int i = 0; i < LIVES; i++)
            {
                string lifeName = "Life" + (i + 1);
                PlayerPrefs.SetInt(lifeName, lives);
            }
            SceneManager.LoadScene(sceneId); // tiene que cargar la misma escena en la que está
        }
            
    }
    void PauseGame()
    {

        paused = true;
        Camera.main.GetComponent<AudioSource>().Stop();
        txtMessage.text = "PAUSED \nPRESS <P> TO RESUME";
        Time.timeScale = 0;
    }
    void ResumeGame()
    {
        paused = false;
        Camera.main.GetComponent<AudioSource>().Play();
        txtMessage.text = "";
        Time.timeScale = 1;

    }
}

