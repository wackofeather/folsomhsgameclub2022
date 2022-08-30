using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speed : MonoBehaviour
{
    float angle;
    float sailwindangle;
    Quaternion sailpulled;
    Quaternion sailletted;
    float boatspeed = 0;
    public GameObject windvector;
    public GameObject Anglecheckers;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        sailwindangle = Anglecheckers.GetComponent<anglechecker>().sailwindangle;
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        angle = gameObject.transform.rotation.eulerAngles.y - windvector.transform.rotation.eulerAngles.y;
         rb.AddForce(0,0,boatspeed);


        if ((angle < 45) && (angle > 10))
        {
            //Debug.Log("cool");
            
            
            if (sailwindangle < 90)
            {
              boatspeed = 5 - (5 - sailwindangle);
               
            }
            
            

        }
        
    }
}
