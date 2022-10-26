using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsmovement : MonoBehaviour
{
    public CharacterController charcontroller;
    public float speed;
    public float gravity = -9.81f;
    Vector3 velocity = Vector3.zero;
    public Transform groundcheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public float switchtime;
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
    public bool funsyss;
    public GameObject sitdownleft;
    public GameObject sitdownright;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
         boated = Physics.CheckSphere(groundcheck.position, 0.6f, boatground);
          if (boated == true)
          {
             child.transform.parent = boatparent.transform;
          }
          if (boated == false)
          {
              child.transform.parent = null;
          }



        if (Input.GetKeyDown(KeyCode.F))
        {
            funsyss = true;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            funsyss = false;
        }




        if (funsyss == true)
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
            if (whichside == true)
            {
                gameObject.transform.position = Vector3.SmoothDamp(transform.position, sitdownleft.transform.position, ref velocity, switchtime);
                //gameObject.transform.position = sitdownleft.transform.position;
            }
            if (whichside == false)
            {
                gameObject.transform.position = Vector3.SmoothDamp(transform.position, sitdownright.transform.position, ref velocity, switchtime);
                //gameObject.transform.position = sitdownright.transform.position;
            }
        }
      
           
         
        //Vector3 externalMovement = transform.position - _savePosition;
        if (funsyss == false)
        {
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
}