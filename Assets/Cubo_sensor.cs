using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo_sensor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Controle_cubo>())
        {
            GetComponent<Renderer>().material.color = other.GetComponent<Renderer>().material.color;
            other.GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
