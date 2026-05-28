using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public InteractiveArea InteractiveArea;

    public TextMeshProUGUI TextoTimer;
    public TextMeshProUGUI TextoScore;

    public GameObject PanelVictoria;
    public GameObject PanelDerrota;

    float Tiempo = 15f;
    bool JuegoTerminado = false;
    public int MaximoScore = 4;

    // Start is called before the first frame update
    void Awake()
    {
        InteractiveArea = GameObject.FindObjectOfType<InteractiveArea>();
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
        
        if (InteractiveArea.Score >= MaximoScore && !JuegoTerminado)
        {
            Debug.Log("YOU WIN");
            JuegoTerminado = true;
            PanelVictoria.SetActive(true);
        }
        
        if (Tiempo <= 0 && !JuegoTerminado)
        {
            Debug.Log("GAME OVER");
            JuegoTerminado = true;
            PanelDerrota.SetActive(true);
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
