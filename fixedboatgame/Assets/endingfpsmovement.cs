using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endingfpsmovement : MonoBehaviour
{
    public Transform groundcheck;
    public LayerMask groundMask;
    public float groundDistance;
    bool grounded;
    Vector3 velocity = Vector3.zero;
    public float jumpheight = 3f;
    public float gravity = -9.81f;
    public CharacterController charcontroller;
    public float speed;
    public bool iswalking;
    public bool canmove;
    public Animator animationcontroller;
    public GameObject endtrigger;
    public GameObject endplace;
    Vector3 velocitys;
    public float teleportime;
    public bool cameraunlock;
    public float rotationdelta;
    public GameObject cameras;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            canmove = !canmove;
        }
        if (canmove)
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
            if (((x != 0) | (z != 0)) && grounded)
            {
                iswalking = true;
            }
            if (((x == 0) && (z == 0)) | !grounded)
            {
                iswalking = false;
            }
            Vector3 move = transform.right * x + transform.forward * z;
            charcontroller.Move((Vector3.Normalize(move) * speed * Time.deltaTime));
            velocity.y += gravity * Time.deltaTime;
            charcontroller.Move(velocity * Time.deltaTime);
            cameraunlock = false;
            
        }
        animationcontroller.SetBool("isWalking", iswalking);

        bool ending = endtrigger.GetComponent<endtrigger>().ending;
        if ((!canmove) && (ending))
        {
            gameObject.GetComponent<CharacterController>().enabled = false;
            gameObject.transform.position = Vector3.SmoothDamp(gameObject.transform.position, endplace.transform.position, ref velocitys, teleportime * Time.deltaTime);
            gameObject.transform.rotation = Quaternion.RotateTowards(gameObject.transform.rotation, endplace.transform.rotation, rotationdelta * Time.deltaTime);
            cameras.transform.localRotation = Quaternion.RotateTowards(cameras.transform.localRotation, Quaternion.Euler(0, cameras.transform.localEulerAngles.y, cameras.transform.localEulerAngles.z), rotationdelta * Time.deltaTime);
            if ((Vector3.Distance(gameObject.transform.position, endplace.transform.position) < 0.1f))
            {

                if ((Mathf.DeltaAngle(gameObject.transform.eulerAngles.y, endplace.transform.eulerAngles.y) < 0.1))
                {
                    cameraunlock = true;
                }
               
                iswalking = false;
            }
        }
    }

}
