using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smoothestsailing : MonoBehaviour
{
    // Start is called before the first frame update
    float angle;
    float bruhangle;
    float easeangle;
    float isrotating;
    public float sailanglefromzero;
    bool bruh;
    public GameObject rotationchecker;
    public GameObject windvector;
    public GameObject boat;
    public Quaternion sailpulled = Quaternion.Euler(0f, 15f, 0f);
    public Quaternion sailletted = Quaternion.Euler(0f, 90f, 0f);
    Quaternion sailflip;
    Quaternion sailstate;
    float amogus;
    bool shee;
    float rotationstate;
    // Start is called before the first frame update
    void Start()
    {
        bruh = true;
        shee = true;
    }


    // Update is called once per frame
    void Update()
    {
        sailanglefromzero = Mathf.Abs(Mathf.DeltaAngle(gameObject.transform.localEulerAngles.y, 0));
        
        //float amogustest = Mathf.Abs(Mathf.DeltaAngle(gameObject.transform.localEulerAngles.y, 0));
        //Debug.Log(amogustest);
        if ((boat.transform.localEulerAngles.y > 20) && (boat.transform.localEulerAngles.y < 170))
        {
            
            sailletted = Quaternion.Euler(0f, 270f, 0f);

            sailpulled = Quaternion.Euler(0f, 345f, 0f);
        }
        if ((boat.transform.localEulerAngles.y < 340) && (boat.transform.localEulerAngles.y > 190))
        {
            sailletted = Quaternion.Euler(0f, 90f, 0f);

            sailpulled = Quaternion.Euler(0f, 0f, 0f);
        }
        //Debug.Log(boat.transform.localEulerAngles.y);
        float scrollDir = Input.GetAxis("Mouse ScrollWheel");

        angle = boat.transform.rotation.eulerAngles.y - windvector.transform.rotation.eulerAngles.y;
        bruhangle = Quaternion.Angle(boat.transform.rotation, windvector.transform.rotation);
        easeangle = Mathf.DeltaAngle(boat.transform.localEulerAngles.y, windvector.transform.localEulerAngles.y);
        //Debug.Log(easeangle);
        isrotating = rotationchecker.GetComponent<boatrotation>().isrotating;
        
        if ((bruhangle < 20) && (bruhangle > 0) && (shee == true))
        {
            
            //se

            
            
            if (bruh == true)
            {

                sailstate = gameObject.transform.localRotation;
                amogus = Mathf.Abs(Mathf.DeltaAngle(gameObject.transform.localEulerAngles.y, 0));

                rotationstate = isrotating;

                if ((amogus > 89.5) && (rotationstate == 1))
                {
                    //Debug.Log("bruhhhhhh");
                    sailflip = Quaternion.Euler(0, 271, 0);
                }
                if ((amogus > 89.5) && (rotationstate == -1))
                {
                    //Debug.Log("bruhhhhhh");
                    sailflip = Quaternion.Euler(0, 89, 0);
                }

                if (amogus < 89.5)
                {
                   // Debug.Log("WHYYYYYY");
                   sailflip = Quaternion.Euler(0, (2*(90-gameObject.transform.localEulerAngles.y)) + 180 + gameObject.transform.localEulerAngles.y, 0);
                }
                    

                bruh = false;

            }
            
            float huh = (2*amogus)/0.01f;
            float huhh = 0.2f;
            if (rotationstate == 1) // 1 is right, -1 is left
            {
                if (easeangle > -10)
                {
                    
                    if (isrotating == -1)
                    {
                        //PROBLEM SPOT
                        if (amogus > 55)
                        {
                            //   Debug.Log("itworks!");
                            gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailstate, 0.4f);
                        }
                        else
                        {
                            gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailstate, 0.7f); // use huh somehow .
                                                                                                                                                //huh += 0.1f;
                        }

                        //Debug.Log("shee");
                    }
                    if (isrotating == 1)
                    {
                        if (amogus > 55)
                        {
                            Debug.Log("itworks!!!!");
                            gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, Quaternion.Euler(0, 0, 0), 0.05f);
                        }
                        else
                        {
                            gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, Quaternion.Euler(0, 0, 0), 0.05f); //use huh somehow .....
                                                                                                                                               //huhh += 0.1f;
                        }

                        //Debug.Log("nah");
                    }
                }
                if (easeangle < -10)
                {
                    if (isrotating == -1)
                    {
                        //PROBLEM SPOT
                        if (amogus > 55)
                        {
                            //   Debug.Log("itworks!");
                            gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailstate, 0.4f);
                        }
                        else
                        {
                            gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailstate, 0.7f); // use huh somehow .
                                                                                                                                                //huh += 0.1f;
                        }

                        //Debug.Log("shee");
                    }
                    if (isrotating == 1)
                    {
                        if (amogus > 55)
                        {
                            //Debug.Log("itworks!!!!");
                            gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailflip, 600f * Time.deltaTime);
                        }
                        else
                        {
                            gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailflip, 550f * Time.deltaTime); //use huh somehow
                                                                                                                                               //huhh += 0.1f;
                        }

                        //Debug.Log("nah");
                    }
                }
                
            }
            if (rotationstate == -1)
            {
                if (easeangle < 10)
                {
                    if (isrotating == -1)
                    {
                        //PROBLEM SPOT
                        if (amogus > 55)
                        {
                            //   Debug.Log("itworks!");
                            gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, Quaternion.Euler(0, 0, 0), 0.05f);
                        }
                        else
                        {
                            gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, Quaternion.Euler(0, 0, 0), 0.05f); // use huh somehow .
                                                                                                                                               //huh += 0.1f;
                        }

                        //Debug.Log("shee");
                    }
                    if (isrotating == 1)
                    {
                        if (amogus > 55)
                        {
                            //Debug.Log("itworks!!!!");
                            gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailstate, 0.4f);
                        }
                        else
                        {
                            gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailstate, 0.7f); //use huh somehow
                                                                                                                                                //huhh += 0.1f;
                        }

                        //Debug.Log("nah");
                    }
                }
                if (easeangle > 10)
                {
                    if (isrotating == -1)
                    {
                        //PROBLEM SPOT
                        if (amogus > 55)
                        {
                            //   Debug.Log("itworks!");
                            gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailflip, 600f * Time.deltaTime);
                        }
                        else
                        {
                            gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailflip, 550f * Time.deltaTime); // use huh somehow .
                                                                                                                                               //huh += 0.1f;
                        }

                        //Debug.Log("shee");
                    }
                    if (isrotating == 1)
                    {
                        if (amogus > 55)
                        {
                            //Debug.Log("itworks!!!!");
                            gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailstate, 0.4f);
                        }
                        else
                        {
                            gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailstate, 0.7f); //use huh somehow
                                                                                                                                                //huhh += 0.1f;
                        }

                        //Debug.Log("nah");
                    }
                }
               
            }
            
            
            
            

           


        }
        
        
        
        
        if ((bruhangle > 170) && (shee == true))
        {
            //Debug.Log("cmonwork");
            if (bruh == true)
            {

                sailstate = gameObject.transform.localRotation;
                amogus = Mathf.Abs(Mathf.DeltaAngle(gameObject.transform.localEulerAngles.y, 0));
                rotationstate = isrotating;

                if ((amogus > 89.5) && (rotationstate == -1))
                {
                    //Debug.Log("bruhhhhh");
                    sailflip = Quaternion.Euler(0, 271, 0);
                }
                if ((amogus > 89.5) && (rotationstate == 1))
                {
                    //Debug.Log("bru");
                    sailflip = Quaternion.Euler(0, 89, 0);
                }

                if (amogus < 89.5)
                {
                    //Debug.Log("WHYYYYYY");
                    sailflip = Quaternion.Euler(0, (2 * (90 - gameObject.transform.localEulerAngles.y)) + 180 + gameObject.transform.localEulerAngles.y, 0);
                }


                bruh = false;

            }

            float huh = 0.2f;
            float huhh = 0.2f;
            if (rotationstate == 1)
            {
                if (isrotating == -1)
                {
                    
                    //PROBLEM SPOT
                    if (amogus > 55)
                    {
                        //Debug.Log("itworks!");
                        gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailstate, 0.7f);
                    }
                    else
                    {
                        gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailstate, 0.5f); // use huh somehow .
                        //huh += 0.1f;
                    }

                    //Debug.Log("shee");
                }
                if (isrotating == 1)
                {
                    if (amogus > 85)
                    {
                        gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailflip, 0.9f);
                    }
                    if (amogus > 55)
                    {
                        //Debug.Log("itworks!!!!");
                        gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailflip, 0.7f);
                    }
                    else
                    {
                        gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailflip, 0.5f); //use huh somehow
                        //huhh += 0.1f;
                    }

                    //Debug.Log("nah");
                }
            }
            if (rotationstate == -1)
            {
                if (isrotating == -1)
                {
                    if (amogus > 85)
                    {
                        gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailflip, 0.9f);
                    }
                    //PROBLEM SPOT
                    if (amogus > 55)
                    {
                       //Debug.Log("itworks!");
                        gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailflip, 0.7f);
                    }
                    else
                    {
                        gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailflip, 0.5f); // use huh somehow .
                        //huh += 0.1f;
                    }

                    //Debug.Log("shee");
                }
                if (isrotating == 1)
                {
                    if (amogus > 55)
                    {
                        //Debug.Log("itworks!!!!");
                        gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailstate, 0.7f);
                    }
                    else
                    {
                        gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailstate, 0.5f); //use huh somehow
                        //huhh += 0.1f;
                    }

                    //Debug.Log("nah");
                }
            }


            


        




            
        }
      

        if ((bruhangle > 20) && (bruhangle < 170))
        {
            shee = true;
            bruh = true;
            //Debug.Log("meme");
        }
        


        if (scrollDir > 0)
        {
            transform.localRotation = Quaternion.RotateTowards(transform.localRotation, sailletted, 2000f * Time.deltaTime);
            //out

        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            //in
            transform.localRotation = Quaternion.Slerp(transform.localRotation, sailpulled, 30f * Time.deltaTime);
        }
    }
}
