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


    // public GameObject imagenUI;
    // GameObject objetoActual;

    // void Start()
    // {
        // imagenUI.SetActive(false);
    // }

    // void OnTriggerEnter(Collider other)
    // {
        // if (other.CompareTag("Pickable"))
        // {
            // objetoActual = other.gameObject;
            // imagenUI.SetActive(true);
        // }
    // }

    // void OnTriggerExit(Collider other)
    // {
        // if (other.CompareTag("Pickable"))
        // {
            // imagenUI.SetActive(false);
            // objetoActual = null;
        // }
    // }

    // void Update()
    // {
        // if (Input.GetKeyDown(KeyCode.E) && objetoActual != null)
        // {
            // Destroy(objetoActual);
            // imagenUI.SetActive(false);
        // }
    // }
}