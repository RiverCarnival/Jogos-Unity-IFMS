using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controle_personagem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       // transform.position = new Vector3(0, 0, 10);
        GetComponent<Renderer>().material.color = Color.red;
    }



    private bool movimento_habilitado = true;



    // Update is called once per frame
    void Update()
    {
        if (movimento_habilitado)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(5 * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(-5 * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(0, -45 * Time.deltaTime, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(0, 45 * Time.deltaTime, 0);
            }
            if(Input.GetKeyDown(KeyCode.Space) && destruirArmadilha)
            {
                destruirArmadilhas();
            }
        
        }
        }


    private void destruirArmadilhas()
    {
        foreach( armadilha sensor in GameObject.FindObjectsOfType<armadilha>())
        {
           if(Vector3.Distance(gameObject.transform.position, sensor.transform.position) < 10)
            {
                Destroy(sensor.gameObject);

            }
        }
        destruirArmadilha = false;
    }

   

   public void desabilitar()
    {
        int i = 0;
        while (i < 3)
        movimento_habilitado = false;
        Invoke("habilitar", 4);
        GetComponent<Renderer>().material.color = Color.white;
        if(i == 2)
        {
            Destroy(gameObject);
        }
        i++;
    }


    void habilitar()
    {
        movimento_habilitado = true;
    }



    bool destruirArmadilha = false;
   public void Habilitar_poder_destroi_trap()
    {
        destruirArmadilha = true;
    }



    public void recebeArma(GameObject arma)
    {
        arma.transform.parent = this.transform;
        arma.transform.localPosition = transform.Find("arma").localPosition;
    }

    public zonaColeta ZonaColeta;

}
