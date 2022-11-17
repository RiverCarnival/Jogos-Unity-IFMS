using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sensoArmadilha : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<controlePersonagem>())
        {
            other.GetComponent<controlePersonagem>().desabilitarMovimento();
            Destroy(gameObject);
        }
    }
}
