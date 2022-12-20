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
    public float maxrotataionspeed;
    public float rotationspeed;
    public GameObject centerofmass;
    bool funsyss;
    void Start()
    {
        rb.centerOfMass = centerofmass.transform.localPosition;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.maxAngularVelocity = maxrotataionspeed;

        /*if (issailing == true)
        {*/
        if (funsyss == true)
        {
           // gameObject.transform.rotation = Quaternion.Euler(0f, boatangle, 0f);
            isrotating = 0;
            if (Input.GetMouseButton(0))
            {
               // rb.AddTorque(transform.up * rotationspeed * 1);
               // boatangle += 40f *Time.deltaTime;
                isrotating = 1;
            }
            if (Input.GetMouseButton(1))
            {
                
                //boatangle -= 40f * Time.deltaTime;
                isrotating = -1;
            }
            if (isrotating == 0)
            {
                rb.angularVelocity *= 0.6f;
            }
            boatangle = boat.transform.localEulerAngles.y;
           // Debug.Log(boatangle);
           // boatangle = boatangle % 360;
            // rb.MoveRotation(Quaternion.Euler(0f, boatangle, 0f));
            rb.AddTorque(Vector3.up * isrotating * rotationspeed, ForceMode.VelocityChange);
        }
        if (funsyss == false)
        {
            rb.angularVelocity *= 0.9f;
        }
          
        /*}*/
        

        
        
    }
    private void LateUpdate()
    {
        funsyss = player.GetComponent<fpsmovement>().funsyss;
    }
}
