using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texts : MonoBehaviour
{
    // Start is called before the first frame update
   [SerializeField] string nome = "teste";
   [SerializeField] string sobrenome;
   [SerializeField] string nomeCompleto;
   [SerializeField] Text test;
    void Start()
    {
        nome = "troca";
        nomeCompleto = nome +" "+ sobrenome;
        test.text = nomeCompleto;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
