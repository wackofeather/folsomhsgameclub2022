using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatmovetest : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, 10);
    }
}
/*    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class supersailing : MonoBehaviour
{
    // Start is called before the first frame update
    float angle;
    float bruhangle;
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
    Quaternion ghostsailstate;
    float amogus;
    bool shee;
    float rotationstate;
    bool changemind;
    public GameObject ghostsail;
    bool ghostsailfollow;
    bool ghostinstantiate;
    float ghostrotate;
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
        sailanglefromzero = Mathf.Abs(Mathf.DeltaAngle(gameObject.transform.localEulerAngles.y, 0));
        mixedboatangle = boat.transform.localEulerAngles.y - windvector.transform.localEulerAngles.y;
        //float amogustest = Mathf.Abs(Mathf.DeltaAngle(gameObject.transform.localEulerAngles.y, 0));
        //Debug.Log(mixedboatangle);
        if ((mixedboatangle > 20) && (mixedboatangle < 170))
        {

            sailletted = Quaternion.Euler(0f, 270f, 0f);

            sailpulled = Quaternion.Euler(0f, 345f, 0f);
        }
        if ((mixedboatangle < 340) && (mixedboatangle > 190))
        {
            sailletted = Quaternion.Euler(0f, 90f, 0f);

            sailpulled = Quaternion.Euler(0f, 0f, 0f);
        }
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
            float huhh = 0.2f;
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
            changemind = false;
            //Debug.Log("meme");
        }



        if ((bruhangle > 40) && (bruhangle < 180))
        {
            ghostsailfollow = true;
        }
        Debug.Log("GF" + ghostsailfollow);
        Debug.Log("GI" + ghostinstantiate);




        if ((bruhangle > 20) && (bruhangle < 60))
        {
            ghostsailfollow = false;
            //Debug.Log("fart");
        }
        //Debug.Log(bruhangle);

        if ((ghostsailfollow == true) && (ghostinstantiate == true))
        {

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
            if (ghostinstantiate == true)
            {
                //k
                //Debug.Log("fart");
                ghostsailstate = ghostsail.transform.localRotation;
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
        if ((ghostsailfollow == true) && (ghostinstantiate == false))
        {
            gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, ghostsail.transform.localRotation, 1f);
            if (ghostsail.transform.localRotation == gameObject.transform.localRotation)
            {
                ghostinstantiate = true;
            }

        }








        //Debug.Log("thsipartworks");





        //Debug.Log(rotationstate);
    }*/
/*}

}*/
