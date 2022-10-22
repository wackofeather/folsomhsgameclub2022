using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ducking : MonoBehaviour
{
    public Camera cameraboi;
    bool shessjs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
           
        
      
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("bruh");
        cameraboi.transform.position = new Vector3(cameraboi.transform.position.x, -1,cameraboi.transform.position.z);
        shessjs = true;
    }
    private void OnTriggerExit(Collider other)
    {
        cameraboi.transform.position = new Vector3(cameraboi.transform.position.x, 1, cameraboi.transform.position.z);
        shessjs = false;
    }



}
