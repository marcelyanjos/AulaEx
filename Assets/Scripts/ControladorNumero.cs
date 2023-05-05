using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorNumero : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject _cube;
    [SerializeField] GameObject _sphere;
    [SerializeField] GameObject _capsule;
    [SerializeField] GameObject _cylinder;
    [SerializeField] int _numero;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_numero == 1)
        {
            _cube.SetActive(true);
        }
        else if(_numero == 2) {
            _sphere.SetActive(true);
        }
        else if(_numero == 3) {
            _capsule.SetActive(true);
        }
        else if(_numero == 4) {
            _cylinder.SetActive(true);
        }

        if(_numero < 1) {
            _cube.SetActive(false);
            _sphere.SetActive(false);
            _capsule.SetActive(false);
            _cylinder.SetActive(false);
        }
        else if(_numero > 4) {
            _cube.SetActive(true);
            _sphere.SetActive(true);
            _capsule.SetActive(true);
            _cylinder.SetActive(true);
        }

            
    }
}
