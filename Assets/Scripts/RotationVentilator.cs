using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationVentilator : MonoBehaviour
{
    public int VelocidadRotacion = 5;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, VelocidadRotacion, 0);
    }
}
