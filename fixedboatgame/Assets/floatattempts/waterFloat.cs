using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterFloat : MonoBehaviour
{
        public float waterlevel;
        Rigidbody rb;
    float mass = 0;
    float speed = 0;
        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();
           mass = GetComponent<Rigidbody>().mass;
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("bruh");

        if (speed > mass)
        {
            Debug.Log("mass");
            speed = mass;
        }
    }

    void Update() // Update is called once per frame
        {
            var vel = GetComponent<Rigidbody>().velocity;      //to get a Vector3 representation of the velocity
            speed = (vel.magnitude);                     // to get magnitude
         
        float y_pos = transform.position.y;
                if (y_pos < waterlevel)
                {
                    if (speed < 1) {

                          speed = 1;
                    }
            
                    rb.AddForce(transform.up * speed);
                }
        }
  
}
