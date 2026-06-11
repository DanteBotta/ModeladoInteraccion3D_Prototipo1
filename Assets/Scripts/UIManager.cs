using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject PanelVictoria;
    public GameObject PanelDerrota;
    public GameObject TextoOcultar1;
    public GameObject TextoOcultar2;

    public void MostrarPantallaWin()
    {
        PanelVictoria.SetActive(true);
        TextoOcultar1.SetActive(false);
        TextoOcultar2.SetActive(false);
    }

    public void MostrarPantallaGameOver()
    {
        PanelDerrota.SetActive(true);
        TextoOcultar1.SetActive(false);
        TextoOcultar2.SetActive(false);
    }
}