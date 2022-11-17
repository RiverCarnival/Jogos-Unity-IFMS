using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle_cubo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3((float)-6.19, (float)-9.43248, (float)-4.19);
    }

    // Update is called once per frame
    private bool movimentoHabilitado = true;

    void Update()
    {
        if (movimentoHabilitado)
        {
            if (Input.GetKey(KeyCode.W))
                transform.Translate(7 * Time.deltaTime, 0, 0);
            if (Input.GetKey(KeyCode.A))
                transform.Rotate(0, -45 * Time.deltaTime, 0);
            if (Input.GetKey(KeyCode.D))
                transform.Rotate(0, 45 * Time.deltaTime, 0);
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(-5 * Time.deltaTime, 0, 0);
            }
        }
    }

       


}
