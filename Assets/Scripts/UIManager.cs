using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject PanelVictoria;
    public GameObject PanelDerrota;

    public void MostrarPantallaWin()
    {
        PanelVictoria.SetActive(true);
    }

    public void MostrarPantallaGameOver()
    {
        PanelDerrota.SetActive(true);
    }
}