using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colider : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<controle_personagem>())
        {
            other.GetComponent<controle_personagem>().recebeArma(transform.parent.gameObject);
            Destroy(gameObject);
        }
    }


    public void coletar()
    {

    }



}
