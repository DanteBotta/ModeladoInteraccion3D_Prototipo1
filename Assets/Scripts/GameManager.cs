using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public InteractiveArea InteractiveArea;

    public TextMeshProUGUI TextoTimer;
    public TextMeshProUGUI TextoScore;

    float Tiempo = 5f;
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
        if (JuegoTerminado == false){
            TextoScore.text = "Score: " + score.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Tiempo >= 0 && JuegoTerminado == false)
        {
            Tiempo -= Time.deltaTime;
            TextoTimer.text = "Tiempo: " + Tiempo.ToString("F1");
        }
        
        if (InteractiveArea.Score >= MaximoScore)
        {
            Debug.Log("YOU WIN");
            JuegoTerminado = true;
        }
        
        if (Tiempo <= 0)
        {
            TextoTimer.text = "Game Over";
            Debug.Log("GAME OVER");
            JuegoTerminado = true;
        }
        
    }
}
