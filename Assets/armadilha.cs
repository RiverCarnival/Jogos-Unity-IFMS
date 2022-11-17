using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armadilha : MonoBehaviour
{
    // Start is called before the first frame update

    private void Start()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }

    private void OnTriggerEnter(Collider other)
    {
        GetComponent<Renderer>().material.color = Color.blue;
        if (other.GetComponent<controle_personagem>())
        {
            other.GetComponent<controle_personagem>().desabilitar();
            Destroy(gameObject);
        }
    }
}
