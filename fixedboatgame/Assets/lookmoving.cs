using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookmoving : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = transform.GetChild(0).GetComponent<Rigidbody>();
        
        gameObject.transform.rotation = Quaternion.LookRotation(rb.velocity, transform.up); //s
    }
}
