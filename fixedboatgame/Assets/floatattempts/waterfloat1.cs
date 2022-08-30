using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterfloat1 : MonoBehaviour
{
    public float waterlevel;
    Rigidbody rb;
    float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
    rb = GetComponent<Rigidbody>();
    }

void Update()
    {
        var vel = GetComponent<Rigidbody>().velocity;      //to get a Vector3 representation of the velocity
        speed = (vel.magnitude);                     // to get magnitude
        float y_pos = transform.position.y;
       
    }
    
    
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("bruh");
        rb.AddForce(transform.up * speed * 3, ForceMode.Impulse);

    }
    void OnTriggerStay(Collider other)
    {
        Debug.Log("boi");
        rb.AddForce(transform.up * 1 , ForceMode.Impulse);

    }



}
// if (y_pos < waterlevel)
//{
//if (speed < 1)
//{

//speed = 1;
//}

//}

//public float waterlevel;
//Rigidbody rb;
//float speed = 0;
// Start is called before the first frame update
//void Start()
//{
//rb = GetComponent<Rigidbody>();
//}


//void OnTriggerEnter(Collider other)
//{
//rb.AddForce(transform.up * speed);
//}
// Update is called once per frame
//void Update()
//{
//var vel = GetComponent<Rigidbody>().velocity;      //to get a Vector3 representation of the velocity
//speed = (vel.magnitude);                     // to get magnitude
//float y_pos = transform.position.y;
//if (speed < 1)
//{

//speed = 1;


//}

//}