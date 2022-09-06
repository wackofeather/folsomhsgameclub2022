using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speed : MonoBehaviour
{
    float angle;
    float sailwindangle;
    float sailanglefromzero;
    Quaternion sailpulled;
    Quaternion sailletted;
    float boatspeed = 0;
    float boatvelocity;
    public GameObject windvector;
    public GameObject Anglecheckers;
    public GameObject boat;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        angle = gameObject.transform.rotation.eulerAngles.y - windvector.transform.rotation.eulerAngles.y;
        boatvelocity = rb.velocity.magnitude;
        Debug.Log(boatvelocity);
        if (boatvelocity < 1)
        {
            Debug.Log("shesh");
            rb.AddForce((transform.forward * -700f) * Time.deltaTime);
        }
         
        sailwindangle = Anglecheckers.GetComponent<anglechecker>().sailwindangle;
        sailanglefromzero = Anglecheckers.GetComponent<smoothestsailing>().sailanglefromzero;
        //Debug.Log(angle);
        float boatwindangles = Quaternion.Angle(gameObject.transform.rotation, windvector.transform.rotation);
        //Debug.Log(sailwindangle);

        if ((angle>20) && (angle < 40)) //this dosen't work rn but i have more important stuff to fix first
        {
            if (sailwindangle < 10)
            {
                boatspeed = 0.1f * (10 - sailwindangle);
            }
        }
        
    }
}
