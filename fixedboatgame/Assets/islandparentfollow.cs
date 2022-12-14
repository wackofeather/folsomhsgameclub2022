using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class islandparentfollow : MonoBehaviour
{
    public GameObject islandprefab;
    public GameObject surroundingwaterprefab;
    public GameObject boat;
    public Transform parent;
    public GameObject sail;
    public float initialdistance;
    public float initialdowndistance;
    public float endingupdistance;
    Quaternion keyrotation;
    GameObject sheeshjk;
    GameObject water;
    public float bigupspeed;
    public float initialscale;
    public float distancefactor;
    public bool islandinstantiate;
    public bool islandcheck;
    public bool keepscaling;
    public float endupscale;
    public float backwardfactor;
    public float scaletest;
    // Start is called before the first frame update
    void Start()
    {
        islandcheck = true;
        keepscaling = true;
    } //sss

    // Update is called once per frame
    void FixedUpdate()
    {
      
    
        if (Input.GetKeyDown(KeyCode.M))
        {
            islandinstantiate = true;
        }

        if (islandinstantiate == true)
        {

            SpawnIsland();
            islandinstantiate = false;
            islandcheck = false;
        }


        if ((islandinstantiate == false) && (islandcheck == false))
        {
            float distance = Vector3.Distance(boat.transform.position, sheeshjk.transform.position);
            if (sheeshjk.transform.localScale.x > endupscale)
            {
                Debug.Log("this part works");
                keepscaling = false;
            }
          
           
            Debug.Log(distance);
            if ((distance > initialdistance + 15) && (keepscaling = false))
            {
                keepscaling = true;
            }


            if (keepscaling == true)
            {/*
                initialdistance = initialdistance + (backwardfactor * (sheeshjk.transform.localScale.x / initialscale));
                Debug.Log((backwardfactor * (sheeshjk.transform.localScale.x / initialscale)));
                sheeshjk.transform.localPosition = new Vector3(sheeshjk.transform.localPosition.x, sheeshjk.transform.localPosition.y, -initialdistance); //10 is endingupscale ((endingupdistance - initialdowndistance) / (endupscale - initialscale)) * (sheeshjk.transform.localScale.x - initialscale) + initialdowndistance*/
                sheeshjk.transform.parent = parent;
                sheeshjk.transform.rotation = Quaternion.identity;
                Rigidbody rb = boat.GetComponent<Rigidbody>();
                //Debug.Log(Mathf.Abs(Mathf.DeltaAngle(boat.transform.localEulerAngles.y, parent.transform.localEulerAngles.y)));
                bool ispowered = sail.GetComponent<anglechecker>().goofyahash;
                parent.transform.position = boat.transform.position;
                if ((Mathf.Abs(Mathf.DeltaAngle(boat.transform.localEulerAngles.y, parent.transform.localEulerAngles.y)) < 60) && (ispowered))
                {
                // Debug.Log("bruh");
                    sheeshjk.transform.localScale = sheeshjk.transform.localScale * (1 + bigupspeed);
                }
                if ((Mathf.Abs(Mathf.DeltaAngle(boat.transform.localEulerAngles.y, parent.transform.localEulerAngles.y)) < 60) && (ispowered))
                {
                  //  Debug.Log("bruh");
                    sheeshjk.transform.localScale = sheeshjk.transform.localScale * (1 + bigupspeed);
                }
                if ((Mathf.Abs(Mathf.DeltaAngle(boat.transform.localEulerAngles.y, parent.transform.localEulerAngles.y)) > 120) && (ispowered))
                {
                   // Debug.Log("bruh");
                    sheeshjk.transform.localScale = sheeshjk.transform.localScale * (1 - bigupspeed / 2);
                }
                if ((Mathf.Abs(Mathf.DeltaAngle(boat.transform.localEulerAngles.y, parent.transform.localEulerAngles.y)) > 120) && (ispowered))
                {
                  //  Debug.Log("bruh");
                    sheeshjk.transform.localScale = sheeshjk.transform.localScale * (1 - bigupspeed / 2);
                }
                /*    Vector3 boatvelocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
                    float distance = Vector3.Distance(boat.transform.position, sheeshjk.transform.position);
                    float finaldistance = distance * sheeshjk.transform.localScale.x * distancefactor;
                    float addtheta = Mathf.Asin((boatvelocity.x) / (finaldistance));
                    Quaternion addthetaquaternion = Quaternion.Euler(0, addtheta * Mathf.Rad2Deg, 0);
                    parent.transform.rotation = parent.transform.rotation * addthetaquaternion;*/
                Vector3 boatvelocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
                // float distance = Vector3.Distance(boat.transform.position, sheeshjk.transform.position);
                /*  if (sheeshjk.transform.localScale.x > ((initialscale + endupscale) / 2))
                   {
                        scaletest = (sheeshjk.transform.localScale.x);
                   }
                   if (sheeshjk.transform.localScale.x < ((initialscale + endupscale) / 2))
                   {
                       scaletest = (1/sheeshjk.transform.localScale.x);
                   }*/
                scaletest = (1 / sheeshjk.transform.localScale.x);
                float finaldistance = distance * scaletest * distancefactor;
                float addtheta = Mathf.Asin((boatvelocity.x) / (finaldistance));
                Debug.Log(addtheta);
                Quaternion addthetaquaternion = Quaternion.Euler(0, addtheta * Mathf.Rad2Deg, 0);
                parent.transform.rotation = parent.transform.rotation * addthetaquaternion;
            }


            if (keepscaling == false)
            {
               sheeshjk.transform.parent = null;
                parent.transform.position = boat.transform.position;
            }
        }

      

    }
    public void SpawnIsland()
    {
        FindObjectOfType<AudioManager>().Play("music");
        //Debug.Log("meme");
        keyrotation = Quaternion.Euler(0, 0, 0); //Random.Range(0, 360)
        sheeshjk = Instantiate(islandprefab);
      /*  water = Instantiate(surroundingwaterprefab);
        water.transform.position = new Vector3(0, 1000, - initialdistance);*/
        parent.transform.rotation = keyrotation;
        // sheeshjk.transform.parent = parent;
        sheeshjk.transform.position = new Vector3(0, initialdowndistance, -initialdistance);
        sheeshjk.transform.localScale = Vector3.one * initialscale;
    }
}
