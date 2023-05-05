using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CondicionaisCombinadas : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject _cube;
    [SerializeField] Rigidbody _cubeRig;
    [SerializeField] BoxCollider _cubeBox;

    [SerializeField] GameObject _sphere;
    [SerializeField] Rigidbody _sphereRig;

    [SerializeField] GameObject _capsule;
    [SerializeField] Rigidbody _capsuleRig;

    [SerializeField] GameObject _cylinder;
    [SerializeField] Rigidbody _cylinderRig;

    [SerializeField] float _numero;
    [SerializeField] string _texto;
    [SerializeField] bool _check;
    void Start()
    {
       _cubeBox = _cube.GetComponent<BoxCollider>();
        if(_cubeBox != null)
        {
            _cubeBox.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(_check==true && _numero == 1) {
            _cube.SetActive(true);
            _cubeRig.useGravity = false;
            _cubeRig.isKinematic = true;

            _sphere.SetActive(false);
            _capsule.SetActive(false);
            _cylinder.SetActive(false);

         }
        else if (_check == true && _numero == 2)
        {
            _cube.SetActive(false);
            _sphere.SetActive(true);
            _capsule.SetActive(false);
            _cylinder.SetActive(false);
        }
    }
}
