using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUP : MonoBehaviour
{
     // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,9 * Time.deltaTime, 45 * Time.deltaTime);
    }
    private void Start()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<controle_personagem>())
        {
            other.GetComponent<controle_personagem>().Habilitar_poder_destroi_trap();
            Destroy(this);
        }
    }


}
