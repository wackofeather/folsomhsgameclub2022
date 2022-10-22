using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ducking : MonoBehaviour
{
    Vector3 cameraduck;
    public Camera cameraboi;
    bool shessjs;
    bool duckinstantiate;
    public float duckheight;
    Vector3 velocity = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        duckinstantiate = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
           if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("bbruh");
            shessjs = true;
            if (duckinstantiate == true)
            {
                cameraduck = new Vector3(cameraboi.transform.localPosition.x, cameraboi.transform.localPosition.y - duckheight, cameraboi.transform.localPosition.z);
                duckinstantiate = false;
            }

            cameraboi.transform.localPosition = cameraduck; //Vector3.SmoothDamp(transform.localPosition, cameraduck, ref velocity, 100f)
        }
      
           if (Input.GetKey(KeyCode.E) == false)
        {
            Debug.Log("heheh");
            if (duckinstantiate == false)
            {
                cameraduck = new Vector3(cameraboi.transform.localPosition.x, cameraboi.transform.localPosition.y + duckheight, cameraboi.transform.localPosition.z); //s
                cameraboi.transform.localPosition = cameraduck;
                duckinstantiate = true;
            }
            shessjs = false;
        }
     
      
    }
   /* private void OnTriggerEnter(Collider other)
    {
        Debug.Log("bruh");
        cameraboi.transform.position = new Vector3(cameraboi.transform.position.x, -1,cameraboi.transform.position.z);
        shessjs = true;
    }
    private void OnTriggerExit(Collider other)
    {
        cameraboi.transform.position = new Vector3(cameraboi.transform.position.x, 1, cameraboi.transform.position.z);
        shessjs = false;
    }*/



}
