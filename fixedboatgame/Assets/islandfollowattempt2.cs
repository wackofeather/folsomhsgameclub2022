using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class islandfollowattempt2 : MonoBehaviour
{
    public LayerMask boatground;
    public float initialdowndistance;
    public float endingdowndistance;
    bool isfar;
    float boatstartx;
    float boatstarty;
    public float thetascale;
    public GameObject islandprefab;
    public Transform islanddiamtercheck;
    GameObject sheeshjk;
    public GameObject parent;
    public GameObject boat;
    Quaternion keyrotation;
  //  public float OGartificialdistance;
    public float OGad;
    public float artificialdistance;
    public float distance;
    public float cutoff;
    public float islanddiameter;
    public Rigidbody boatrigidbody;
    public float endscale;
    public float initialscale;
    bool islandinstantiate;
    bool keepscaling;
    public float donottypevaluesdownhere;
    float scale;
    float xvelocity;
    float zvelocity;
    public GameObject islandtrackerflow;
    // Start is called before the first frame update
    void Start()
    {
        boatstartx = boat.transform.position.x;
        OGad = artificialdistance;
        islandinstantiate = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       // Debug.Log(keepscaling);
      //  Debug.Log(scale);
        if (Input.GetKeyDown(KeyCode.M))
        {

            SpawnIsland();
            keepscaling = true;
        }
        if (islandinstantiate == true)
        {
            parent.transform.position = new Vector3(boatstartx, 0, boat.transform.position.z);
            islanddiamtercheck = sheeshjk.transform.Find("usethis");
            Vector3 bruh = new Vector3(islanddiamtercheck.position.x, islanddiamtercheck.position.y, islanddiamtercheck.position.z);
            float arghdistance = Vector3.Distance(bruh, parent.transform.position);
            //Debug.Log(arghdistance);
          
            xvelocity = boatrigidbody.velocity.x;
            zvelocity = -boatrigidbody.velocity.z;
         /*   Debug.Log(xvelocity + "bruh");
            Debug.Log(zvelocity);*/
           // sheeshjk.transform.localScale = new Vector3(initialscale, initialscale, initialscale);
           


         /*   if ((scale < endscale + 1) && (scale > endscale - 1))
            {
                keepscaling = false;
            }*/
        /*    if ((scale > -1) && (scale < endscale - 1))
            {
                keepscaling = true;
            }*/
            if ((artificialdistance < cutoff) && (keepscaling == true))
            {
              
          
                keepscaling = false;
                //artificialdistance = cutoff;
            }
            Debug.Log(keepscaling);

         /*  
            if ((artificialdistance > cutoff - 1) && (artificialdistance < OGad + 1))
            {
                keepscaling = true;
            }*/
                            if (keepscaling == true)
                            {
                              
                                artificialdistance = artificialdistance - zvelocity;
                                float m = (endscale - initialscale) / (cutoff - OGad);
                                scale = ((m * (artificialdistance - OGad)) + initialscale);
                               
                                sheeshjk.transform.localScale = Vector3.one * Mathf.Clamp(scale, 0, endscale);




/*                                float a = Root((initialdowndistance/endingdowndistance), (OGad - cutoff));
                                 float ypos = initialdowndistance * (Mathf.Pow(a, artificialdistance - cutoff));
                                sheeshjk.transform.position = new Vector3(sheeshjk.transform.position.x, ypos, sheeshjk.transform.position.z);*/ //GET THIS WORKING
                
                                
                             /*   float finaldistance = artificialdistance * scale * thetascale; //  * scale
                                  float addtheta = Mathf.Asin((xvelocity) / (finaldistance));
                                // Debug.Log(addtheta);
                                Quaternion addthetaquaternion = Quaternion.Euler(0, addtheta * Mathf.Rad2Deg, 0);
                                parent.transform.rotation = parent.transform.rotation * addthetaquaternion;
                                sheeshjk.transform.rotation = Quaternion.identity;
*/
                               sheeshjk.transform.parent = parent.transform;
                            }


                            if (keepscaling == false)
                            {
                                
                                 sheeshjk.transform.parent = null;
                                    isfar = Physics.CheckSphere(sheeshjk.transform.position, distance, boatground);

                                if (isfar == false)
                                {
                                    artificialdistance = cutoff;
                                   // Debug.Log("this part works");
                                    keepscaling = true;
                                }
                             }
           


            //thisbit dosent work
                    
        }

        
     
    }
    public void SpawnIsland()
    {
        FindObjectOfType<AudioManager>().Play("music");
        //Debug.Log("meme");
       keyrotation = Quaternion.Euler(0, 0, 0); //Random.Range(0, 360)
        sheeshjk = Instantiate(islandprefab);
      //  sheeshjk.transform.parent = parent.transform;
        sheeshjk.transform.localScale = Vector3.one * initialscale;
        /*  water = Instantiate(surroundingwaterprefab);
          water.transform.position = new Vector3(0, 1000, - initialdistance);*/
        parent.transform.rotation = keyrotation;
        // sheeshjk.transform.parent = parent;
        sheeshjk.transform.position = new Vector3(parent.transform.position.x, -10.760000228881836f, parent.transform.position.z-distance);
        
        // sheeshjk.transform.localScale = Vector3.one * initialscale;
        keepscaling = true;
        islandinstantiate = true;
    }
    float Root(float what, float power)
    {

        if (what < 0.0f)
        {

            return -Mathf.Pow(what, 1/power);
        }

        else
        {

            return Mathf.Pow(what, 1/power);
        }
    }
}
