using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscolheACarta : MonoBehaviour
{
    int NumerosDasCartas;


    // Start is called before the first frame update
    void Start()
    {


        Debug.Log("Olá, vamos divertir-nos!!");
        Debug.Log("Carrega na tecla espaço para te sair uma carta");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            NumerosDasCartas = Random.Range(1, 10);
        }

        Debug.Log("A carta que te saiu foi" + NumerosDasCartas);
    }
}
