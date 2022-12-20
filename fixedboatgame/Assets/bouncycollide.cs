using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncycollide : MonoBehaviour
{
    public GameObject boat;
    public GameObject sail;
    public Collider boatcollider;
    public Collider islandcollidertest;
    public LayerMask islandground;
    public float intensity;
    Vector3 reflectforce;
    public Rigidbody boatrb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /*   private void OnCollisionEnter(Collision collision)
       {
         //  
          // Rigidbody boatrb = boat.GetComponent<Rigidbody>();
           Debug.Log(collision.contacts[0].normal);
               Debug.Log(collision.gameObject);
               reflectforce = Vector3.Reflect(boatrb.velocity, collision.contacts[0].normal) * intensity;
               boatrb.AddForce(reflectforce, ForceMode.Impulse);

       }*/
    private void OnTriggerStay(Collider other)
    {
       // Debug.Log("ahhhh");
        sail.GetComponent<anglechecker>().nearwall = true;
        
    }
    private void OnTriggerExit(Collider other)
    {
        sail.GetComponent<anglechecker>().nearwall = false;
    }
}
