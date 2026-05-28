using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveArea : MonoBehaviour
{
    public GameManager GameManager;
    public UIManager UIManager;

    public int Score = 0;

    void Awake()
    {
        GameManager = GameObject.FindObjectOfType<GameManager>();
        UIManager = GameObject.FindObjectOfType<UIManager>();
    }

    private void OnTriggerEnter(Collider other) 
    { 
        if (other.gameObject.CompareTag("Pickable")) 
        { 
            Destroy(other.gameObject); 
            Score += 1;
            GameManager.UpdateScore(Score);

            if (Score >= GameManager.MaximoScore)
            {
                UIManager.MostrarPantallaWin();
                Time.timeScale = 0;
                GameManager.JuegoTerminado = true;
            }
        } 
    }
}