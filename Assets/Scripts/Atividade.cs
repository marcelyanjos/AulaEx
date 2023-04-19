using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atividade : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] string nome1 = "atividade";
    [SerializeField] string nome2;
    [SerializeField] string nome3;
    string nNomes;
    

    void Start()
    {
        nome1 = "troca";
        nNomes = nome1 + nome2 + nome3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
