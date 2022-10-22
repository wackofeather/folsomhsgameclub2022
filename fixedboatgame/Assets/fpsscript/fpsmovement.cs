using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsmovement : MonoBehaviour
{
    public CharacterController charcontroller;
    public float speed;
    public float gravity = -9.81f;
    Vector3 velocity;
    public Transform groundcheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public float jumpheight = 3f;
    bool grounded;
    public LayerMask boatground;
    bool boated;
    public GameObject boatparent;
    public GameObject child;
    Vector3 _savePosition;
    public GameObject sail;
    bool whichside;
    bool hassitdown;
    bool funsyss;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            
                    Debug.Log(whichside);
                    float mixedboatangle = sail.GetComponent<supersailing>().mixedboatangle;
                    if ((mixedboatangle > 20) && (mixedboatangle < 170))
                    {
                        whichside = true; //sitdownleft
                    }
                    if ((mixedboatangle < 340) && (mixedboatangle > 190))
                    {
                        whichside = false; // sitdownright
                    }
            
           
       
       
        }
         boated = Physics.CheckSphere(groundcheck.position, groundDistance, boatground);
          if (boated == true)
          {
             child.transform.parent = boatparent.transform;
          }
          if (boated == false)
          {
              child.transform.parent = null;
          }
         
        //Vector3 externalMovement = transform.position - _savePosition;

        grounded = Physics.CheckSphere(groundcheck.position, groundDistance, groundMask);
        //Debug.Log(grounded);

        if (grounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        if (Input.GetButtonDown("Jump") && grounded)
        {
            velocity.y = Mathf.Sqrt(jumpheight * -2 * gravity);
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        charcontroller.Move((Vector3.Normalize(move) * speed * Time.deltaTime));
        velocity.y += gravity * Time.deltaTime;
        charcontroller.Move(velocity * Time.deltaTime);
        //_savePosition = transform.position;

    }
}