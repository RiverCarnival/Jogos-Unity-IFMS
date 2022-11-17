using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpDestroyArmadilhas : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,90*Time.deltaTime, 45 * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<controlePersonagem>())
        {
            other.GetComponent<controlePersonagem>().habilitarPoderDestruirArmadilha();
            Destroy(gameObject);
        }
    }
}
