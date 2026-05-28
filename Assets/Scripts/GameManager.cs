using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public InteractiveArea InteractiveArea;
    public UIManager UIManager;

    public TextMeshProUGUI TextoTimer;
    public TextMeshProUGUI TextoScore;

    float Tiempo = 15f; = false;

    public int MaximoScore = 4;

    // Start is called before the first frame update
    void Awake()
    {
        InteractiveArea = GameObject.FindObjectOfType<InteractiveArea>();
        UIManager = GameObject.FindObjectOfType<UIManager>();

        Time.timeScale = 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        UpdateScore(0);
    }

    public void UpdateScore(int score)
    {
        if (!JuegoTerminado)
        {
            TextoScore.text = "Score: " + score.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Tiempo >= 0 && !JuegoTerminado)
        {
            Tiempo -= Time.deltaTime;
            TextoTimer.text = "Tiempo: " + Tiempo.ToString("F1");
        }
        
        if (Tiempo <= 0 && !JuegoTerminado)
        {
            Debug.Log("GAME OVER");

            JuegoTerminado = true;

            UIManager.MostrarPantallaGameOver();

            Time.timeScale = 0;
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            if (JuegoTerminado)
            {
                SceneManager.LoadScene("Juego");
            }
        }
    }
}