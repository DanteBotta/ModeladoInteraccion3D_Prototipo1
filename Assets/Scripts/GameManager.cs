using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI TextoTimer;
    float Tiempo = 30f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Tiempo >= 0)
        {
            Tiempo -= Time.deltaTime;
            TextoTimer.text = "Tiempo: " + Tiempo.ToString("F1");
            Debug.Log("GAME OVER");
        }
        
    }
}
