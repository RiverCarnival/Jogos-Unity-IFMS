using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projetil : MonoBehaviour
{


    public GameObject explosao;
    public float velocidade = 20;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, velocidade * Time.deltaTime);
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag != "robo")
        {
            Destroy(Instantiate(explosao, transform.position, explosao.transform.rotation), 3);
            Destroy(gameObject);
            
        }
    }


}
