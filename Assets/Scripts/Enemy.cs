using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform pos;
    [SerializeField] Vector3 pos2;
    void Start()
    {
        pos.localScale = new Vector3(2,2,2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
