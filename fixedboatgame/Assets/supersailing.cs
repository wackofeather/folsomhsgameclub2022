using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class supersailing : MonoBehaviour
{
    // Start is called before the first frame update
    float angle;
    public float bruhangle;
    float easeangle;
    float isrotating;
    public float sailanglefromzero;
    public float mixedboatangle;
    bool bruh;
    public GameObject rotationchecker;
    public GameObject windvector;
    public GameObject boat;
    public Quaternion sailpulled = Quaternion.Euler(0f, 15f, 0f);
    public Quaternion sailletted = Quaternion.Euler(0f, 90f, 0f);
    Quaternion sailflip;
    Quaternion sailstate;
    Quaternion fart;
    Quaternion ghostsailstate;
    Quaternion ghostsailflip;
    float amogus;
    float ghostamogus;
    bool shee;
    float rotationstate;
    bool changemind;
    public GameObject ghostsail;
    public bool ghostsailfollow;
    bool ghostinstantiate;
    float ghostrotate;
    Quaternion sailimp;
    Quaternion bruhtho;
    float sailimpy;
    Quaternion whathe;
    float whatheEuler;
    public bool fartsysus;
    bool whytho;
    bool howtho;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        bruh = true;
        shee = true;
        ghostinstantiate = true;
    }


    // Update is called once per frame
    void Update()
    {
        bool funsyss = player.GetComponent<fpsmovement>().funsyss;
        //Rigidbody rb = boat.GetComponent<Rigidbody>();

        //Debug.Log(mixedboatangle);
       // Debug.Log(mixedboatangle);
        sailanglefromzero = Mathf.Abs(Mathf.DeltaAngle(gameObject.transform.localEulerAngles.y, 0));
        mixedboatangle = boat.transform.localEulerAngles.y-windvector.transform.localEulerAngles.y;
        //float amogustest = Mathf.Abs(Mathf.DeltaAngle(gameObject.transform.localEulerAngles.y, 0));
        //Debug.Log(ghostsailfollow);
        if ((mixedboatangle > 20) && (mixedboatangle < 170))
        {

            sailletted = Quaternion.Euler(0f, 270f, 0f);

            sailpulled = Quaternion.Euler(0f, 345f, 0f);
        }
        if ((mixedboatangle < 340) && (mixedboatangle > 190))
        {
            sailletted = Quaternion.Euler(0f, 90f, 0f);

            sailpulled = Quaternion.Euler(0f, 15f, 0f);
        }
        if (funsyss == true)
        {
            //Debug.Log(boat.transform.localEulerAngles.y);
            float scrollDir = Input.GetAxis("Mouse ScrollWheel");

            angle = boat.transform.rotation.eulerAngles.y - windvector.transform.rotation.eulerAngles.y;
            bruhangle = Quaternion.Angle(boat.transform.rotation, windvector.transform.rotation);
            easeangle = Mathf.DeltaAngle(boat.transform.localEulerAngles.y, windvector.transform.localEulerAngles.y);
            //Debug.Log(boat.transform.rotation.eulerAngles.y);
            isrotating = rotationchecker.GetComponent<boatrotation>().isrotating;

            if ((bruhangle < 20) && (bruhangle > 0) && (shee == true))
            {

                //se



                if (bruh == true)
                {

                    sailstate = gameObject.transform.localRotation;
                    amogus = Mathf.Abs(Mathf.DeltaAngle(gameObject.transform.localEulerAngles.y, 0));
                    //ghostamogus = Mathf.Abs(Mathf.DeltaAngle(ghostsail.transform.localEulerAngles.y, 0));
                    //ghostsailstate = ghostsail.transform.localRotation;
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
                        sailflip = Quaternion.Euler(0, (2 * (90 - gameObject.transform.localEulerAngles.y)) + 180 + gameObject.transform.localEulerAngles.y, 0);
                    }

                    bruh = false;

                }

                float huh = (2 * amogus) / 0.01f;
                if (rotationstate == 1) // 1 is right, -1 is left
                {
                    if (easeangle > -10)
                    {

                        if (isrotating == -1)
                        {
                            //PROBLEM SPOT
                            if (changemind == false)
                            {
                                if (amogus > 55)
                                {
                                    //   Debug.Log("itworks!");
                                    gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailstate, 50f * Time.deltaTime);
                                }
                                else
                                {
                                    gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailstate, 25f * Time.deltaTime); // use huh somehow .
                                                                                                                                                                        //huh += 0.1f;
                                }
                            }
                            if (changemind == true)
                            {
                                if (amogus > 55)
                                {
                                    //   Debug.Log("itworks!");
                                    gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailstate, 300f * Time.deltaTime);
                                }
                                else
                                {
                                    gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailstate, 300f * Time.deltaTime); // use huh somehow .
                                                                                                                                                                         //huh += 0.1f;
                                }
                            }


                            //Debug.Log("shee");
                        }
                        if (isrotating == 1)
                        {
                            if (amogus > 55)
                            {
                                //Debug.Log("itworks!!!!");
                                gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, Quaternion.Euler(0, 0, 0), 50f * Time.deltaTime);
                            }
                            else
                            {
                                gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, Quaternion.Euler(0, 0, 0), 25f * Time.deltaTime); //use huh somehow .......
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
                                gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailstate, 50f * Time.deltaTime);
                            }
                            else
                            {
                                gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailstate, 25f * Time.deltaTime); // use huh somehow .
                                                                                                                                                                    //huh += 0.1f;
                            }
                            changemind = true;

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
                            changemind = false;
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
                                gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, Quaternion.Euler(0, 0, 0), 50f * Time.deltaTime);
                            }
                            else
                            {
                                gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, Quaternion.Euler(0, 0, 0), 25f * Time.deltaTime); // use huh somehow .
                                                                                                                                                                                    //huh += 0.1f;
                            }

                            //Debug.Log("shee");
                        }
                        if (isrotating == 1)
                        { // PROBLEMMMMMM
                            if (changemind == false)
                            {
                                if (amogus > 55)
                                {
                                    //   Debug.Log("itworks!");
                                    gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailstate, 50f * Time.deltaTime);
                                }
                                else
                                {
                                    gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailstate, 25f * Time.deltaTime); // use huh somehow .
                                                                                                                                                                        //huh += 0.1f;
                                }
                            }
                            if (changemind == true)
                            {
                                if (amogus > 55)
                                {
                                    //   Debug.Log("itworks!");
                                    gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailstate, 300f * Time.deltaTime);
                                }
                                else
                                {
                                    gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailstate, 300f * Time.deltaTime); // use huh somehow .
                                                                                                                                                                         //huh += 0.1f;
                                }
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
                            changemind = false;
                            //Debug.Log("shee");
                        }
                        if (isrotating == 1)
                        {
                            if (amogus > 55)
                            {
                                //Debug.Log("itworks!!!!");
                                gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailstate, 50f * Time.deltaTime);
                            }
                            else
                            {
                                gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailstate, 25f * Time.deltaTime); //use huh somehow..
                                                                                                                                                                    //huhh += 0.1f;
                            }
                            changemind = true;
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
                            gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailflip, 3f);
                        }
                        if (amogus > 55)
                        {
                            //Debug.Log("itworks!!!!");
                            gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailflip, 2.5f);
                        }
                        else
                        {
                            gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailflip, 2f); //use huh somehow
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
                            gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailflip, 3f);
                        }
                        //PROBLEM SPOT
                        if (amogus > 55)
                        {
                            //Debug.Log("itworks!");
                            gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailflip, 2.5f);
                        }
                        else
                        {
                            gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailflip, 2f); // use huh somehow .
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
                changemind = false;
                //Debug.Log("meme");
            }
            if ((bruhangle > 40) && (bruhangle < 180))
            {
                ghostsailfollow = true;
            }
            //Debug.Log("GF" + ghostsailfollow);
            // Debug.Log("GI" + ghostinstantiate);

            if (ghostsail.transform.localRotation == gameObject.transform.localRotation)
            {
                fartsysus = true;
            }
            if (ghostsail.transform.localRotation != gameObject.transform.localRotation)
            {
                fartsysus = false;
            }

            if ((bruhangle > 0) && (bruhangle < 60))
            {
                ghostsailfollow = true;
                //Debug.Log("fart");
            }
            //Debug.Log(bruhangle);

            if ((ghostsailfollow == true) && (ghostinstantiate == true))
            {

                howtho = true;
                whytho = true;
                if (scrollDir > 0)
                {
                    transform.localRotation = Quaternion.RotateTowards(transform.localRotation, sailletted, 2000f * Time.deltaTime); //s
                    //out
                    

                }
                if (Input.GetAxis("Mouse ScrollWheel") < 0)
                {
                    //in
                    transform.localRotation = Quaternion.Slerp(transform.localRotation, sailpulled, 30f * Time.deltaTime);
                }
                ghostsail.transform.localRotation = gameObject.transform.localRotation;
            }
            if (ghostsailfollow == false)
            {
                if ((bruhangle > 20) && (bruhangle < 60))
                {
                    //Debug.Log(Mathf.Abs(Quaternion.Angle(gameObject.transform.localRotation, Quaternion.identity)));
                    if (Mathf.Abs(Quaternion.Angle(gameObject.transform.localRotation, Quaternion.identity)) > 20)
                    {
                        if (ghostinstantiate == true)
                        {
                            //k
                            //Debug.Log("fart");
                            //we may need a sort of ghostsailstate = ghostsail.transform.localRotation;
                            ghostinstantiate = false;
                        }
                        if (ghostinstantiate == false)
                        {

                            if (scrollDir > 0)
                            {
                                ghostsail.transform.localRotation = Quaternion.RotateTowards(ghostsail.transform.localRotation, sailletted, 2000f * Time.deltaTime);
                            }

                            if ((Input.GetAxis("Mouse ScrollWheel") < 0))
                            {
                                if (ghostsail.transform.localRotation.y > gameObject.transform.localRotation.y)
                                {
                                    ghostsail.transform.localRotation = Quaternion.Slerp(transform.localRotation, sailpulled, 30f * Time.deltaTime);
                                }
                                else
                                {
                                    ghostsail.transform.localRotation = Quaternion.Slerp(transform.localRotation, sailpulled, 30f * Time.deltaTime);
                                    gameObject.transform.localRotation = Quaternion.Slerp(transform.localRotation, sailpulled, 30f * Time.deltaTime);
                                }
                                //in

                            }
                        }
                    }
                    else if (Mathf.Abs(Quaternion.Angle(gameObject.transform.localRotation, Quaternion.identity)) < 20)
                    {
                        if (scrollDir > 0)
                        {
                            if (ghostsail.transform.localRotation.y > gameObject.transform.localRotation.y)
                            {
                                ghostsail.transform.localRotation = Quaternion.RotateTowards(ghostsail.transform.localRotation, sailletted, 2000f * Time.deltaTime);
                            }
                            else
                            {
                                ghostsail.transform.localRotation = Quaternion.Slerp(transform.localRotation, sailletted, 30f * Time.deltaTime);
                                gameObject.transform.localRotation = Quaternion.Slerp(transform.localRotation, sailletted, 30f * Time.deltaTime);
                            }

                        }

                        if ((Input.GetAxis("Mouse ScrollWheel") < 0))
                        {
                            if (ghostsail.transform.localRotation.y > gameObject.transform.localRotation.y)
                            {
                                ghostsail.transform.localRotation = Quaternion.Slerp(transform.localRotation, sailpulled, 30f * Time.deltaTime);
                            }
                            else
                            {
                                ghostsail.transform.localRotation = Quaternion.Slerp(transform.localRotation, sailpulled, 30f * Time.deltaTime);
                                gameObject.transform.localRotation = Quaternion.Slerp(transform.localRotation, sailpulled, 30f * Time.deltaTime);
                            }
                            //in

                        }
                    }
                }
                else
                {
                    if (ghostinstantiate == true)
                    {
                        //k
                        //Debug.Log("fart");
                        //we may need a sort of ghostsailstate = ghostsail.transform.localRotation;
                        ghostinstantiate = false;
                    }
                    if (ghostinstantiate == false)
                    {

                        if (scrollDir > 0)
                        {
                            ghostsail.transform.localRotation = Quaternion.RotateTowards(ghostsail.transform.localRotation, sailletted, 2000f * Time.deltaTime);
                        }

                        if ((Input.GetAxis("Mouse ScrollWheel") < 0))
                        {
                            if (ghostsail.transform.localRotation.y > gameObject.transform.localRotation.y)
                            {
                                ghostsail.transform.localRotation = Quaternion.Slerp(transform.localRotation, sailpulled, 30f * Time.deltaTime);
                            }
                            else
                            {
                                ghostsail.transform.localRotation = Quaternion.Slerp(transform.localRotation, sailpulled, 30f * Time.deltaTime);
                                gameObject.transform.localRotation = Quaternion.Slerp(transform.localRotation, sailpulled, 30f * Time.deltaTime);
                            }
                            //in

                        }
                    }
                }

                /*
                            if ((bruhangle > 40) && (bruhangle < 180))
                            {
                                ghostsailfollow = true;
                            }
                            //Debug.Log("GF" + ghostsailfollow);
                            // Debug.Log("GI" + ghostinstantiate);

                            if (ghostsail.transform.localRotation == gameObject.transform.localRotation)
                            {
                                fartsysus = true;
                            }
                            if (ghostsail.transform.localRotation != gameObject.transform.localRotation)
                            {
                                fartsysus = false;
                            }

                            if ((bruhangle > 0) && (bruhangle < 60))
                            {
                                ghostsailfollow = false;
                                //Debug.Log("fart");
                            }
                            //Debug.Log(bruhangle);

                            if ((ghostsailfollow == true) && (ghostinstantiate == true))
                            {

                                howtho = true;
                                whytho = true;
                                if (scrollDir > 0)
                                {
                                    transform.localRotation = Quaternion.RotateTowards(transform.localRotation, sailletted, 2000f * Time.deltaTime);
                                    //out

                                }
                                if (Input.GetAxis("Mouse ScrollWheel") < 0)
                                {
                                    //in
                                    transform.localRotation = Quaternion.Slerp(transform.localRotation, sailpulled, 30f * Time.deltaTime);
                                }
                                ghostsail.transform.localRotation = gameObject.transform.localRotation;
                            }
                            if (ghostsailfollow == false)
                            {
                                if ((bruhangle > 20) && (bruhangle < 60))
                                {
                                    //Debug.Log(Mathf.Abs(Quaternion.Angle(gameObject.transform.localRotation, Quaternion.identity)));
                                    if (Mathf.Abs(Quaternion.Angle(gameObject.transform.localRotation, Quaternion.identity)) > 20)
                                    {
                                        if (ghostinstantiate == true)
                                        {
                                            //k
                                            //Debug.Log("fart");
                                            //we may need a sort of ghostsailstate = ghostsail.transform.localRotation;
                                            ghostinstantiate = false;
                                        }
                                        if (ghostinstantiate == false)
                                        {

                                            if (scrollDir > 0)
                                            {
                                                ghostsail.transform.localRotation = Quaternion.RotateTowards(ghostsail.transform.localRotation, sailletted, 2000f * Time.deltaTime);
                                            }

                                            if ((Input.GetAxis("Mouse ScrollWheel") < 0))
                                            {
                                                if (ghostsail.transform.localRotation.y > gameObject.transform.localRotation.y)
                                                {
                                                    ghostsail.transform.localRotation = Quaternion.Slerp(transform.localRotation, sailpulled, 30f * Time.deltaTime);
                                                }
                                                else
                                                {
                                                    ghostsail.transform.localRotation = Quaternion.Slerp(transform.localRotation, sailpulled, 30f * Time.deltaTime);
                                                    gameObject.transform.localRotation = Quaternion.Slerp(transform.localRotation, sailpulled, 30f * Time.deltaTime);
                                                }
                                                //in

                                            }
                                        }
                                    }
                                    else if (Mathf.Abs(Quaternion.Angle(gameObject.transform.localRotation, Quaternion.identity)) < 20)
                                    {
                                        if (scrollDir > 0)
                                        {
                                            if (ghostsail.transform.localRotation.y > gameObject.transform.localRotation.y)
                                            {
                                                ghostsail.transform.localRotation = Quaternion.RotateTowards(ghostsail.transform.localRotation, sailletted, 2000f * Time.deltaTime);
                                            }
                                            else
                                            {
                                                ghostsail.transform.localRotation = Quaternion.Slerp(transform.localRotation, sailletted, 30f * Time.deltaTime);
                                                gameObject.transform.localRotation = Quaternion.Slerp(transform.localRotation, sailletted, 30f * Time.deltaTime);
                                            }

                                        }

                                        if ((Input.GetAxis("Mouse ScrollWheel") < 0))
                                        {
                                            if (ghostsail.transform.localRotation.y > gameObject.transform.localRotation.y)
                                            {
                                                ghostsail.transform.localRotation = Quaternion.Slerp(transform.localRotation, sailpulled, 30f * Time.deltaTime);
                                            }
                                            else
                                            {
                                                ghostsail.transform.localRotation = Quaternion.Slerp(transform.localRotation, sailpulled, 30f * Time.deltaTime);
                                                gameObject.transform.localRotation = Quaternion.Slerp(transform.localRotation, sailpulled, 30f * Time.deltaTime);
                                            }
                                            //in

                                        }
                                    }
                                }
                                else
                                {
                                    if (ghostinstantiate == true)
                                    {
                                        //k
                                        //Debug.Log("fart");
                                        //we may need a sort of ghostsailstate = ghostsail.transform.localRotation;
                                        ghostinstantiate = false;
                                    }
                                    if (ghostinstantiate == false)
                                    {

                                        if (scrollDir > 0)
                                        {
                                            ghostsail.transform.localRotation = Quaternion.RotateTowards(ghostsail.transform.localRotation, sailletted, 2000f * Time.deltaTime);
                                        }

                                        if ((Input.GetAxis("Mouse ScrollWheel") < 0))
                                        {
                                            if (ghostsail.transform.localRotation.y > gameObject.transform.localRotation.y)
                                            {
                                                ghostsail.transform.localRotation = Quaternion.Slerp(transform.localRotation, sailpulled, 30f * Time.deltaTime);
                                            }
                                            else
                                            {
                                                ghostsail.transform.localRotation = Quaternion.Slerp(transform.localRotation, sailpulled, 30f * Time.deltaTime);
                                                gameObject.transform.localRotation = Quaternion.Slerp(transform.localRotation, sailpulled, 30f * Time.deltaTime);
                                            }
                                            //in

                                        }
                                    }
                                }*/


            }
            //LOOK AT COMMENT IN GHOSTSAILING FIRST
            /* if ((ghostsailfollow == false) && (ghostsail.transform.localRotation.y != gameObject.transform.localRotation.y)&&(bruhangle > 20))
             {
                 if (howtho == true)
                 {
                     whathe = gameObject.transform.localRotation;
                     whatheEuler = gameObject.transform.localEulerAngles.y;
                     howtho = false;
                 }

                 if (whytho ==  true)
                 {

                   sailimpy = Quaternion.Angle(ghostsail.transform.localRotation, whathe);
                     bruhtho = ghostsail.transform.localRotation;
                     sailimp = Quaternion.Euler(0, whatheEuler - (sailimpy * 0.2f), 0);
                     whytho = false;
                 }
                 if (ghostsail.transform.localRotation != bruhtho)
                 {
                     whytho = true;
                 }
                 if (gameObject.transform.localRotation == ghostsail.transform.localRotation)
                 {
                     howtho = true;
                 }

                 Debug.Log(gameObject.transform.localEulerAngles.y);
                 Debug.Log(sailimpy);
                 Debug.Log(gameObject.transform.localRotation.y - sailimpy);
                 if ((sailimp != gameObject.transform.localRotation) && (gameObject.transform.localRotation != ghostsail.transform.localRotation))
                 {
                     gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailimp, 0.1f);
                 }

             }*/
            if ((ghostsailfollow == false) && (ghostsail.transform.localRotation.y != gameObject.transform.localRotation.y) && (bruhangle > 20) && (Mathf.Abs(Quaternion.Angle(gameObject.transform.localRotation, Quaternion.identity)) > 20))
            {
                if (gameObject.transform.localRotation != ghostsail.transform.localRotation)
                {
                    if (Mathf.Abs(Quaternion.Angle(gameObject.transform.localRotation, Quaternion.identity)) > 40)
                    {
                        gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, Quaternion.identity, 0.07f);
                    }
                    if (Mathf.Abs(Quaternion.Angle(gameObject.transform.localRotation, Quaternion.identity)) < 40)
                    {
                        gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, Quaternion.identity, 0.01f);
                    }

                }
            }
            if ((ghostsailfollow == true) && (ghostinstantiate == false))
            {
                gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, ghostsail.transform.localRotation, 1f);
                if (ghostsail.transform.localRotation == gameObject.transform.localRotation)
                {
                    ghostinstantiate = true;
                }

            }


        }







        //Debug.Log("thsipartworks");





        //Debug.Log(rotationstate);
    }
    private void FixedUpdate()
    {
      
    }
}
