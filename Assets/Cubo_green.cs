using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo_green : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Controle_cubo>())
        {
            other.GetComponent<Renderer>().material.color = Color.green;
        }
    }

}
