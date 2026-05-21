using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI TextoScore;
    public TextMeshProUGUI TextoTimer;
    float Tiempo = 30f;

    // Start is called before the first frame update
    void Start()
    {
        UpdateScore(0);
    }

    public void UpdateScore(int score)
    {
        TextoScore.text = "Score: " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Tiempo -= Time.deltaTime;
        TextoTimer.text = "Tiempo: " + Tiempo.ToString("F1");

    }
}
