using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo_amarelo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.yellow;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Controle_cubo>())
        {
            other.GetComponent<Renderer>().material.color = Color.yellow;
        }
    }
}
