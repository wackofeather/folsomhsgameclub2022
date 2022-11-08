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
    public GameObject boat;
    Vector3 _savePosition;
    public GameObject sail;
    bool whichside;
    bool hassitdown;
    float dampvelocity = 0;
    public bool funsyss;
    public bool initialsit;
    public GameObject sitdownleft;
    GameObject shee;
    public GameObject sitdownright;
    float distanceleft;
    float distanceright;
    float boatvelocity;
    bool ispowered;
    float counterweight;
    public float memes;
    Vector3 smoothdampvelocity = Vector3.zero;
    public GameObject boatrotater;
    public Camera cameramain;
    Quaternion boattilt;
    Vector3 headback;
    float boatrotatez;
    bool getoff;
    Quaternion charrotation;
    Quaternion charrotationinverse;
    public float bugup;
   
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("music");
        getoff = true;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.deltaTime);
        ispowered = sail.GetComponent<anglechecker>().goofyahash;
        boated = Physics.CheckSphere(groundcheck.position, 1f, boatground);
          if (boated == true)
          {
             child.transform.parent = boatparent.transform;
          }
        if ((boated == false) && (funsyss == false))
          {
              child.transform.parent = null;
          }



        if ((Input.GetKeyDown(KeyCode.F)) && (funsyss == false))
        {
            funsyss = true;
            initialsit = true;
            getoff = false;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            getoff = true;
           
        
         
         /*   if (getoff == true)
            {
                
                charrotationinverse = cameramain.transform.rotation;
                getoff = false;
            }
            
           if (getoff == false)
            {
                cameramain.transform.rotation = charrotationinverse;
                gameObject.transform.rotation = Quaternion.identity;
                getoff = true;
            }*/
           
        }


        if (initialsit == true)
        {


            if (distanceleft < distanceright)
            {
                whichside = true; //sitdownleft


            }
            if (distanceright < distanceleft)
            {
                whichside = false; // sitdownright

            }

            initialsit = false;


        }

        if (funsyss == true)
        {
           // Debug.Log(whichside);
            float mixedboatangle = sail.GetComponent<supersailing>().mixedboatangle;
            distanceleft = Vector3.Distance(sitdownleft.transform.position, gameObject.transform.position);
            distanceright = Vector3.Distance(sitdownright.transform.position, gameObject.transform.position);


            
                boatvelocity = sail.GetComponent<anglechecker>().boatvelocity;
            if (getoff == true)
            {
                boattilt = Quaternion.Euler(0, 0, 0);
                boatrotater.transform.localRotation = Quaternion.RotateTowards(boatrotater.transform.localRotation, boattilt, 30 * Time.deltaTime);
                if (boatrotater.transform.localRotation == Quaternion.identity)
                {
                    funsyss = false;
                }
            }
            if (getoff == false)
            {


                if (Input.GetKeyDown(KeyCode.F))
                {
                    whichside = !whichside;
                }

                //bool sailside;
                if ((mixedboatangle > 0) && (mixedboatangle < 180))
                {
                    if (whichside == true)
                    {
                        if (ispowered == false)
                        {
                            memes = 10f;
                            counterweight = 0;

                            boattilt = Quaternion.Euler(0, 0, 5);

                        }
                        if (ispowered == true)
                        {

                            if (boatrotater.transform.localEulerAngles.z < 14)
                            {
                                if (Input.GetKey(KeyCode.R))
                                {
                                    memes = 5;
                                }
                                if (Input.GetKeyUp(KeyCode.R))
                                {
                                    memes = 10;
                                }
                            }
                            if (boatrotater.transform.localEulerAngles.z > 14)
                            {

                                //memes = 0.2f;
                                if (Input.GetKey(KeyCode.R))
                                {
                                    //Debug.Log(boatrotater.transform.localEulerAngles.z);
                                    counterweight = 75;
                                    memes = 5;
                                    headback = new Vector3(0, 4.04f, -1.25f);
                                    // cameramain.transform.localPosition = headback;
                                    //cameramain.transform.localPosition = Vector3.SmoothDamp(cameramain.transform.localPosition, headback, ref smoothdampvelocity, 0.2f);
                                }
                                if (Input.GetKey(KeyCode.R) == false)
                                {
                                    memes = 10;
                                    Debug.Log(counterweight);
                                    counterweight = 0;
                                    headback = new Vector3(0, 4.04f, 0);
                                    //cameramain.transform.localPosition = headback;
                                    //cameramain.transform.localPosition = Vector3.SmoothDamp(cameramain.transform.localPosition, headback, ref smoothdampvelocity, 0.2f);
                                }
                            }
                            boattilt = Quaternion.Euler(0, 0, 5 + 5.66666f * boatvelocity - counterweight);
                        }
                        //Vector3 headbackdamp = new Vector3(0, 4.04f, headback.z);
                        cameramain.transform.localPosition = new Vector3(0, 4.04f, Mathf.SmoothDamp(cameramain.transform.localPosition.z, headback.z, ref dampvelocity, 20 * Time.deltaTime));
                        // boattilt = Quaternion.Euler(0, 0, -5 + -1 * 5.66666f * boatvelocity + counterweight);
                        boatrotater.transform.localRotation = Quaternion.RotateTowards(boatrotater.transform.localRotation, boattilt, memes * Time.deltaTime);

                        //boatrotater.transform.localRotation = Quaternion.Euler(0, 0, -5); //right 8
                    }


                    if (whichside == false)
                    {
                        memes = 15;
                        //this is the key fotr switch side bug HEREHEKJEHE
                        headback = new Vector3(0, 4.04f, 0);
                        //cameramain.transform.localPosition = headback;
                        cameramain.transform.localPosition = new Vector3(0, 4.04f, Mathf.SmoothDamp(cameramain.transform.localPosition.z, headback.z, ref dampvelocity, 20 * Time.deltaTime));
                        boattilt = Quaternion.Euler(0, 0, 90);
                        boatrotater.transform.localRotation = Quaternion.RotateTowards(boatrotater.transform.localRotation, boattilt, memes * Time.deltaTime);
                        //boatrotater.transform.localRotation = Quaternion.Euler(0, 0, -8);
                    }



/*
                    if (whichside == false)
                    {
                        Debug.Log("aughhh");
                        boattilt = Quaternion.Euler(0, 0, 90);
                        boatrotater.transform.localRotation = Quaternion.RotateTowards(boatrotater.transform.localRotation, boattilt, 0.1f);
                        //boatrotater.transform.localRotation = Quaternion.Euler(0, 0, 8); //right 8
                    }
                    if (whichside == true)
                    {

                        Debug.Log(boatvelocity);
                        if (ispowered == false)
                        {
                            memes = 0.2f;
                            counterweight = 0;
                            boatrotatez = Mathf.SmoothDamp(boatrotater.transform.localEulerAngles.z, boattilt.eulerAngles.z, ref dampvelocity, 0.1f);
                        }
                        if (ispowered == true)
                        {

                            if (boatrotater.transform.localRotation.z < 15)
                            {
                                if (Input.GetKey(KeyCode.R))
                                {
                                    memes = 0.1f;
                                }
                                if (Input.GetKey(KeyCode.R) == false)
                                {
                                    memes = 0.2f;
                                }
                            }
                            if (boatrotater.transform.localEulerAngles.z > 15)
                            {
                                memes = 0.2f;
                                if (Input.GetKey(KeyCode.R))
                                {
                                    counterweight = 75;
*//*
                                    headback = new Vector3(cameramain.transform.localPosition.x, cameramain.transform.localPosition.y, -1.25f);

                                    cameramain.transform.localPosition = Vector3.SmoothDamp(cameramain.transform.localPosition, headback, ref smoothdampvelocity, 0.2f);*//*

                                }
                                if (Input.GetKey(KeyCode.R) == false)
                                {
                                    counterweight = 0;
                                  *//*  headback = new Vector3(cameramain.transform.localPosition.x, cameramain.transform.localPosition.y, 0);
                                    cameramain.transform.localPosition = Vector3.SmoothDamp(cameramain.transform.localPosition, headback, ref smoothdampvelocity, 0.2f);*//*
                                }
                            }
                            //boatrotatez = Mathf.SmoothDamp(boatrotater.transform.localEulerAngles.z, boattilt.eulerAngles.z, ref dampvelocity, 0.4f);

                        }
                        boattilt = Quaternion.Euler(0, 0, 5 + 5.666666f * boatvelocity - counterweight);
                        boatrotater.transform.localRotation = Quaternion.RotateTowards(boatrotater.transform.localRotation, boattilt, 0.2f);
                        *//*  float boatrotatex = Mathf.SmoothDamp(boatrotater.transform.localEulerAngles.x, boattilt.eulerAngles.x, ref dampvelocity, 0.5f);
                          float boatrotatey = Mathf.SmoothDamp(boatrotater.transform.localEulerAngles.y, boattilt.eulerAngles.y, ref dampvelocity, 0.5f);

                          //  Quaternion boattiltdamp = Quaternion.Euler(0, 0, boatrotatez);
                          boatrotater.transform.localRotation = Quaternion.Euler(0, 0, boatrotatez);*//*
                        //boatrotater.transform.localRotation = Quaternion.RotateTowards(boatrotater.transform.localRotation, boattilt, 0.2f);
                        //boatrotater.transform.localRotation = Quaternion.Euler(0, 0, 5);
                    }*/
                    //right 8 ok
                }

                if ((mixedboatangle < 360) && (mixedboatangle > 180))
                {
                    if (whichside == false)
                    {
                        if (ispowered == false)
                        {
                            //memes = 0.2f;
                            counterweight = 0;
                            memes = 20;
                            boattilt = Quaternion.Euler(0, 0, -5);
                           
                        }
                        if (ispowered == true)
                        {

                            if (boatrotater.transform.localEulerAngles.z > 346)
                            {
                                if (Input.GetKey(KeyCode.R))
                                {
                                    memes = 10;
                                    //memes = 0.1f;
                                }
                                if (Input.GetKeyUp(KeyCode.R))
                                {
                                    memes = 20;
                                    //memes = 0.2f;
                                }
                            }
                            if (boatrotater.transform.localEulerAngles.z < 346)
                            {

                                
                                if (Input.GetKey(KeyCode.R))
                                {
                                    //Debug.Log(boatrotater.transform.localEulerAngles.z);
                                    counterweight = 75;
                                    memes = 10;
                                     headback = new Vector3(0, 4.04f, -1.25f);
                                   // cameramain.transform.localPosition = headback;
                                    //cameramain.transform.localPosition = Vector3.SmoothDamp(cameramain.transform.localPosition, headback, ref smoothdampvelocity, 0.2f);
                                }
                                if (Input.GetKey(KeyCode.R) == false)
                                {
                                    memes = 20;
                                    Debug.Log(counterweight);
                                    counterweight = 0;
                                    headback = new Vector3(0, 4.04f, 0);
                                    //cameramain.transform.localPosition = headback;
                                    //cameramain.transform.localPosition = Vector3.SmoothDamp(cameramain.transform.localPosition, headback, ref smoothdampvelocity, 0.2f);
                                }
                            }
                            boattilt = Quaternion.Euler(0, 0, -5 + -1 * 5.66666f * boatvelocity + counterweight);
                        }
                        //Vector3 headbackdamp = new Vector3(0, 4.04f, headback.z);
                        cameramain.transform.localPosition = new Vector3(0,4.04f, Mathf.SmoothDamp(cameramain.transform.localPosition.z, headback.z, ref dampvelocity, 20 * Time.deltaTime));
                       // boattilt = Quaternion.Euler(0, 0, -5 + -1 * 5.66666f * boatvelocity + counterweight);
                        boatrotater.transform.localRotation = Quaternion.RotateTowards(boatrotater.transform.localRotation, boattilt, memes * Time.deltaTime);

                        //boatrotater.transform.localRotation = Quaternion.Euler(0, 0, -5); //right 8
                    }
                    if (whichside == true)
                    {
                        memes = 25;
                        //this is the key fotr switch side bug HEREHEKJEHE
                        headback = new Vector3(0, 4.04f, 0);
                        //cameramain.transform.localPosition = headback;
                        cameramain.transform.localPosition = new Vector3(0, 4.04f, Mathf.SmoothDamp(cameramain.transform.localPosition.z, headback.z, ref dampvelocity, 20 * Time.deltaTime));
                        boattilt = Quaternion.Euler(0, 0, -90);
                        boatrotater.transform.localRotation = Quaternion.RotateTowards(boatrotater.transform.localRotation, boattilt, memes * Time.deltaTime);
                        //boatrotater.transform.localRotation = Quaternion.Euler(0, 0, -8);
                    }
                    //left -8
                }



                if (whichside == true)
                {
                    shee = sitdownleft;
                    gameObject.transform.position = Vector3.SmoothDamp(transform.position, shee.transform.position, ref smoothdampvelocity, switchtime * Time.deltaTime);
                    
                    //gameObject.transform.position = sitdownleft.transform.position;
                }
                if (whichside == false)
                {
                    shee = sitdownright;
                    gameObject.transform.position = Vector3.SmoothDamp(transform.position, shee.transform.position, ref smoothdampvelocity, switchtime * Time.deltaTime);
                    //gameObject.transform.position = sitdownright.transform.position;
                }

            }






            /*  if ((mixedboatangle > 20) && (mixedboatangle < 170))
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
              }*/
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