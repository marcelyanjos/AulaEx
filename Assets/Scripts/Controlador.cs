using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject _cube;
    [SerializeField] GameObject _sphere;
    [SerializeField] GameObject _capsule;
    [SerializeField] GameObject _cylinder;

    [SerializeField] bool _checkCube;
    [SerializeField] bool _checkSphere;
    [SerializeField] bool _checkCapsule;
    [SerializeField] bool _checkCylinder;

    void Start()
    {
        //Cube
        if(_checkCube == true){ 
            _cube.SetActive(false);
        }
        else { 
            _cube.SetActive(true);
        }

        //Sphere
        if (_checkSphere == true)
        {
            _sphere.SetActive(false);
        }
        else
        {
            _sphere.SetActive(true);
        }
        
        //Capsule
        if (_checkCapsule == true)
        {
            _capsule.SetActive(false);
        }
        else
        {
            _capsule.SetActive(true);
        }

        //Cylinder
        if (_checkCylinder == true)
        {
            _cylinder.SetActive(false);
        }
        else
        {
            _cylinder.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
