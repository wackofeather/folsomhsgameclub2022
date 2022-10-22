using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testy : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.K))
        {
            rb.AddForce(Vector3.forward*10);
        }
    }
}
