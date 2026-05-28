using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveArea : MonoBehaviour
{
    public GameManager GameManager;
    public int Score = 0;

    void Awake()
    {
        GameManager = GameObject.FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter(Collider other) 
    { 
        if (other.gameObject.CompareTag("Pickable")) 
        { 
            Destroy(other.gameObject); 
            Score += 1;
            GameManager.UpdateScore(Score);
        } 
    }

    void Update()
    {
        
    }
}