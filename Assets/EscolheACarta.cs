using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscolheACarta : MonoBehaviour
{
    int NumerosDasCartas;
    int Naipes;
    string NomeDosNaipes;
    string Figuras;
  

    // Start is called before the first frame update
    void Start()
    {


        Debug.Log("Olá, vamos divertir-nos!!");
        Debug.Log("Carrega na tecla espaço para te sair uma carta");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NumerosDasCartas = Random.Range(1, 15);
            Naipes = Random.Range(1, 5);

            if (Naipes == 1)
            {
                NomeDosNaipes = "Copas";
            }

            if (Naipes == 2)
            {
                NomeDosNaipes = "Ouros";
            }

            if (Naipes == 3)
            {
                NomeDosNaipes = "Espadas";
            }

            if (Naipes == 4)
            {
                NomeDosNaipes = "Paus";
            }

            if (NumerosDasCartas == 11)
            {
                Figuras = "Rei";
            }

            if (NumerosDasCartas == 12)
            {
                Figuras = "Valete";
            }

            if (NumerosDasCartas == 13)
            {
                Figuras = "Dama";
            }

            if (NumerosDasCartas == 14)
            {
                Figuras = "Ás";
            }

            if (NumerosDasCartas > 10)
            {
                Debug.Log("A carta que te saiu foi " + Figuras + " de " + NomeDosNaipes);
            }
            else
            {
                Debug.Log("A carta que te saiu foi " + NumerosDasCartas + " de " + NomeDosNaipes);
            }
            
        }


        
    }
}
