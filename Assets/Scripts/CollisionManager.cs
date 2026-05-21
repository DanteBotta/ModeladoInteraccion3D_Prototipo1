using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public GameObject imagenUI;
    GameObject objetoActual;

    void Start()
    {
        imagenUI.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickable"))
        {
            objetoActual = other.gameObject;
            imagenUI.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Pickable"))
        {
            imagenUI.SetActive(false);
            objetoActual = null;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && objetoActual != null)
        {
            Destroy(objetoActual);
            imagenUI.SetActive(false);
        }
    }
}