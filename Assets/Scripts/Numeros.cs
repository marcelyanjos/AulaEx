using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Numeros : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int gForte;
    [SerializeField] int gFraca;
    [SerializeField] float gravidade;
    [SerializeField] GameObject bola;
    [SerializeField] Rigidbody massa;
    [SerializeField] Text teste;


    void Start()
    {
       massa.mass = gravidade;
        gravidade = gravidade * 3;
        teste.text = "qualquer coisa " + gravidade;
        //massa.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        massa.mass = gravidade;
    }
}
