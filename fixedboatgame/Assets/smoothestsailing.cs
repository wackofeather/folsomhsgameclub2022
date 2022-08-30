using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smoothestsailing : MonoBehaviour
{
    // Start is called before the first frame update
    float angle;
    float bruhangle;
    float isrotating;
    bool bruh;
    public GameObject rotationchecker;
    public GameObject windvector;
    public GameObject boat;
    public Quaternion sailpulled = Quaternion.Euler(0f, 15f, 0f);
    public Quaternion sailletted = Quaternion.Euler(0f, 90f, 0f);
    Quaternion sailflip;
    Quaternion sailstate;
    float amogus;
    // Start is called before the first frame update
    void Start()
    {
        bruh = true;
    }


    // Update is called once per frame
    void Update()
    {
        float scrollDir = Input.GetAxis("Mouse ScrollWheel");

        angle = boat.transform.rotation.eulerAngles.y - windvector.transform.rotation.eulerAngles.y;
        bruhangle = Quaternion.Angle(boat.transform.rotation, windvector.transform.rotation);
        isrotating = rotationchecker.GetComponent<boatrotation>().isrotating;

        if ((bruhangle < 20) && (bruhangle > 0))
        {
            
            //se

            
            
            if (bruh == true)
            {

                sailstate = gameObject.transform.localRotation;
                amogus = gameObject.transform.localEulerAngles.y;
                if (amogus > 89.5)
                {
                    sailflip = Quaternion.Euler(0, 271, 0);
                }
                else
                {
                    Debug.Log("WHYYYYYY");
                   sailflip = Quaternion.Euler(0, (2*(90-gameObject.transform.localEulerAngles.y)) + 180, 0);
                }
                    

                bruh = false;

            }
            
            float huh = 0.2f;
            float huhh = 0.2f;
            if (isrotating == -1)
            {
                if (amogus > 55)
                {
                    Debug.Log("itworks!");
                    gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailstate, 1f);
                }
                gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailstate, huh);
                huh += 0.1f;
                Debug.Log("shee");
            }
            if (isrotating == 1)
            {
                if (amogus > 55)
                {
                    Debug.Log("itworks!!!!");
                    gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailflip, 1f);
                }
                gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailflip, huhh);
                huhh += 0.1f;
                Debug.Log("nah");
            }
            
            
            

            if (gameObject.transform.localRotation == sailflip)
            {
                sailletted = Quaternion.Euler(0f, 270f, 0f);

                sailpulled = Quaternion.Euler(0f, 345f, 0f);
                huh = 0.2f;
                huhh = 0.2f;
                bruh = true;
            }


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
