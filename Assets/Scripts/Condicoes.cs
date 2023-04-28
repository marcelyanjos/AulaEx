using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicoes : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int _i1, _i2;
    [SerializeField] string _t1, t2;
    [SerializeField] float _f1, _f2;
    [SerializeField] bool _b1, _b2;
    // > Maior
    // < Menor
    // <= Menor ou igual
    // >= Maior ou igual
    // != Diferente
    // == igual


    void Start()
    {
        //_i1 = 1;
        //if (_i1 == 1) {
        //    Debug.Log("fase 1 liberada ");
        //}
        //else
        //{
        //    Debug.Log("Fase 1 bloqueada ");
        //}



        //multiplicar i1 com a i2 
        // se t1 for igual a multiplicação 
        // se nao somar i1 com i2



        _i1 = 2; _i2 = 4;

        if (_t1 == "multiplicação")
        {
            Debug.Log("multiplicação " + _i1 * _i2);
        }
        else
        {
            Debug.Log("Soma " + _i1 + _i2);
        }

        if (_i1 == 2)
        {
            _t1 = "passagem liberada ";     
        }
        else
        {
            _t1 = "passagem bloqueada ";
        }
        Debug.Log(_t1);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
