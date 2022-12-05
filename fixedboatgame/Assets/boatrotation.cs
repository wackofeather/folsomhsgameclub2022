using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatrotation : MonoBehaviour
{
    // Start is called before the first frame update
    public float boatangle;
    public GameObject boat;
    public float isrotating;
    public GameObject player;
    public Rigidbody rb;
    public float rotationspeed;
    bool funsyss;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      

        /*if (issailing == true)
        {*/
        if (funsyss == true)
        {
           // gameObject.transform.rotation = Quaternion.Euler(0f, boatangle, 0f);
            isrotating = 0;
            if (Input.GetMouseButton(0))
            {
               // rb.AddTorque(transform.up * rotationspeed * 1);
                boatangle += 40f *Time.deltaTime;
                isrotating = 1;
            }
            if (Input.GetMouseButton(1))
            {
               
                boatangle -= 40f * Time.deltaTime;
                isrotating = -1;
            }
           // Debug.Log(boatangle);
            boatangle = boatangle % 360;
            rb.MoveRotation(Quaternion.Euler(0f, boatangle, 0f));
        }
          
        /*}*/
        

        
        
    }
    private void LateUpdate()
    {
        funsyss = player.GetComponent<fpsmovement>().funsyss;
    }
}
