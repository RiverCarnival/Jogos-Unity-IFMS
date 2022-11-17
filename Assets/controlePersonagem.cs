using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class controlePersonagem : MonoBehaviour
{
    public TMP_Text txVidas;


    // Start is called before the first frame update
    void Start()
    {
        
        transform.position = new Vector3(0,0,0);
        txVidas.text = "10 Vidas";
    }
    int contVidas = 3;
    int vidas
    {
        get { return contVidas;}

        set
        {
            if(value >= 0 && value < 10)
            {
                contVidas = value;
                txVidas.text = "Vidas:  " + vidas;
            }
        }
    }
    // Update is called once per frame
    private bool movimentoHabilitado = true;
    void Update()
    {
        if (movimentoHabilitado)
        {
            if (Input.GetKey(KeyCode.W))
                transform.Translate(3 * Time.deltaTime, 0, 0);
            if (Input.GetKey(KeyCode.A))
                transform.Rotate(0, -45 * Time.deltaTime, 0);
            if (Input.GetKey(KeyCode.D))
                transform.Rotate(0, 45 * Time.deltaTime, 0);
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(-5 * Time.deltaTime, 0, 0);
            }
            if (Input.GetKeyDown(KeyCode.Space) && destruirArmadilha)
            {
                destruirArmadilhas();
            }
        }
    }

    private void destruirArmadilhas()
    {
        List<sensoArmadilha> listaArmadilhas = new List<sensoArmadilha>( GameObject.FindObjectsOfType<sensoArmadilha>());
        /*for (int i = 0; i < listaArmadilhas.Count; i++)
        {
            if (Vector3.Distance(gameObject.transform.position, listaArmadilhas[i].transform.position) < 10)
                Destroy(listaArmadilhas[i].gameObject);
         }*/
        
        
        foreach (sensoArmadilha sensor in listaArmadilhas)
            if(Vector3.Distance(gameObject.transform.position,sensor.transform.position) < 10)
                Destroy(sensor.gameObject);
        destruirArmadilha = false;
    }

    /// <summary>
    /// Desabilita o movimento do personagem
    /// </summary>
    public void desabilitarMovimento()
    {
        movimentoHabilitado = false;
        Invoke("habilitarMovimento", 4);
        GetComponent<Renderer>().material.color = Color.gray;
        vidas--;
        verificar_vidas();
        txVidas.text = "Vidas: " + vidas; 
    }

    void verificar_vidas()
    {
        if (vidas == 0)
        {
            CancelInvoke("habilitarMovimento");
            GetComponent<Renderer>().material.color = Color.black;
        }
    }

    void habilitarMovimento()
    {
        movimentoHabilitado = true;
        GetComponent<Renderer>().material.color = Color.white;
    }

    bool destruirArmadilha = false;
    public void habilitarPoderDestruirArmadilha()
    {
        vidas++;
        destruirArmadilha = true;
        Invoke("desabilitar_poder", 5);
        GetComponent<Renderer>().material.color = Color.black;
    }

    public void desabilitar_poder()
    {
        destruirArmadilha = false;
    }

}
