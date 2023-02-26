using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class anglechecker : MonoBehaviour
{
    public GameObject windvector;
    public float sailwindangle;
    float bruhangle;
    public GameObject boat;
    float sailanglefromzero;
    public float force;
    public float maxSpeed;
    public bool goofyahash;
    public float gravity;
    public float boatvelocity;
    public float stopfriction;
    public GameObject player;
    public List<ParticleSystem> boatmovingparticles;
  //  public ParticleSystem boatmovingparticles;
    public bool nearwall;
    public float maxlet;
    public float minpull;
    bool funsyss;
    // Start is called before the first frame update
    void Start()
    {
        goofyahash = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (nearwall == false)
        {
            funsyss = player.GetComponent<fpsmovement>().funsyss;

            Quaternion boatangle = boat.transform.rotation;
            bool ghostsailfollow = GetComponent<supersailing>().fartsysus;
            
            sailanglefromzero = Mathf.Floor(Mathf.Abs(Mathf.DeltaAngle(gameObject.transform.localEulerAngles.y, 0)));
            bruhangle = Quaternion.Angle(boat.transform.rotation, windvector.transform.rotation);
            sailwindangle = Quaternion.Angle(gameObject.transform.rotation, windvector.transform.rotation);
            //rb.AddForce(Vector3.down * gravity);
            if (funsyss == true)
            {
                if (bruhangle < 20)
                {
                    goofyahash = false;
                }
                if (bruhangle > 170)
                {
                    goofyahash = false;
                }
                if (bruhangle > 20 && bruhangle < 40)
                {
                    maxlet = 20;
                    minpull = 13;
                    if ((sailanglefromzero <= 20) && (ghostsailfollow == true))
                    {
                      //  rb.AddRelativeForce(Vector3.back * force, ForceMode.VelocityChange); //ssss
                                                                                             //Debug.Log("whataahaha");
                        goofyahash = true;
                    }
                    else
                    {
                        goofyahash = false;
                    }
                    //Debug.Log(sailwindangle);
                }
                if (bruhangle >= 40 && bruhangle <= 70)
                {
                    maxlet = 35;
                    minpull = 20;
                    if ((sailanglefromzero <= 35) && (sailanglefromzero >= 20) && (ghostsailfollow == true))
                    {
                     //   rb.AddRelativeForce(Vector3.back * force, ForceMode.VelocityChange); //sss
                                                                                             // Debug.Log("whataahaha");
                        goofyahash = true;
                    }
                    else
                    {
                        goofyahash = false;
                    }
                    //Debug.Log(sailwindangle);
                }
                if (bruhangle >= 70 && bruhangle <= 100)
                {
                    maxlet = 45;
                    minpull = 35;
                    if ((sailanglefromzero <= 45) && (sailanglefromzero >= 35) && (ghostsailfollow == true))
                    {
                      //  rb.AddRelativeForce(Vector3.back * force, ForceMode.VelocityChange); //sss
                                                                                             //Debug.Log("whataahaha");
                        goofyahash = true;
                    }
                    else
                    {
                        goofyahash = false;
                    }
                    //Debug.Log(sailwindangle);
                }
                if (bruhangle > 100 && bruhangle < 120)
                {
                    maxlet = 60;
                    minpull = 45;
                    if ((sailanglefromzero <= 60) && (sailanglefromzero >= 45) && (ghostsailfollow == true))
                    {
                      //  rb.AddRelativeForce(Vector3.back * force, ForceMode.VelocityChange); //sss
                                                                                             //Debug.Log("whataahaha");
                        goofyahash = true;
                    }
                    else
                    {
                        goofyahash = false;
                    }
                    //Debug.Log(sailwindangle);
                }
                if (bruhangle > 120 && bruhangle < 150)
                {
                    maxlet = 75;
                    minpull = 60;
                    if ((sailanglefromzero <= 75) && (sailanglefromzero >= 60) && (ghostsailfollow == true))
                    {
                       // rb.AddRelativeForce(Vector3.back * force, ForceMode.VelocityChange); //sss
                                                                                             //Debug.Log("whataahaha");
                        goofyahash = true;
                    }
                    else
                    {
                        goofyahash = false;
                    }
                    //Debug.Log(sailwindangle);
                }
                if (bruhangle > 150 && bruhangle < 170)
                {
                    maxlet = 91;
                    minpull = 75;
                    if ((sailanglefromzero <= 91) && (sailanglefromzero >= 75) && (ghostsailfollow == true))
                    {
                      //  rb.AddRelativeForce(Vector3.back * force, ForceMode.VelocityChange); //sss
                                                                                             //Debug.Log("whataahaha");
                        goofyahash = true;
                    }
                    else
                    {
                        goofyahash = false;
                    }
                    //Debug.Log(sailwindangle);
                }
               // rb.drag = 0;
                //Debug.Log(goofyahash);
                /* if (goofyahash == false)
                 {
                     if (rb.velocity.magnitude > 0)
                     {
                        rb.AddRelativeForce(Vector3.forward * (1/rb.velocity.magnitude));
                     }

                 }*/
               // boatvelocity = rb.velocity.magnitude;
               // rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);

            }
            if (funsyss == false)
            {
               
               /* if (rb.velocity.magnitude > 0)
                {
                    rb.drag = stopfriction;
                }*/
                foreach (ParticleSystem p in boatmovingparticles)
                {
                    p.enableEmission = false;
                }
                goofyahash = false;
            }
            if (funsyss == true)
            {
                if (goofyahash == true)
                {
                    foreach (ParticleSystem p in boatmovingparticles)
                    {
                        p.enableEmission = true;
                    }
                }
                if (goofyahash == false)
                {
                    foreach (ParticleSystem p in boatmovingparticles)
                    {
                        p.enableEmission = false;
                    }
                }
            }
         
        }
        if (nearwall == true)
        {
            foreach (ParticleSystem p in boatmovingparticles)
            {
                p.enableEmission = false;
            }
            goofyahash = false;
        }
        /*float angle = boat.transform.rotation.eulerAngles.y;
        float exComponent = Mathf.Cos(angle) * force;
        float yComponent = Mathf.Sin(angle) * force;

        Vector3 forward = new Vector3(-exComponent, -yComponent, 0);*/
       /* Debug.LogAssertion(maxlet);
        Debug.Log(minpull);*/
    }
    void FixedUpdate()
    {
        Rigidbody rb = boat.GetComponent<Rigidbody>();
        if (nearwall == false)
        {
            

            Quaternion boatangle = boat.transform.rotation;
            bool ghostsailfollow = GetComponent<supersailing>().fartsysus;
           // Rigidbody rb = boat.GetComponent<Rigidbody>();
            sailanglefromzero = Mathf.Abs(Mathf.DeltaAngle(gameObject.transform.localEulerAngles.y, 0));
            bruhangle = Quaternion.Angle(boat.transform.rotation, windvector.transform.rotation);
            sailwindangle = Quaternion.Angle(gameObject.transform.rotation, windvector.transform.rotation);
            //rb.AddForce(Vector3.down * gravity);
            if (funsyss == true)
            {
               if (goofyahash)
                {
                    rb.AddRelativeForce(Vector3.back * force, ForceMode.VelocityChange);
                }
                        //ssss
                                                                                             //Debug.Log("whataahaha");
                   
                rb.drag = 0;
                //Debug.Log(goofyahash);
                /* if (goofyahash == false)
                 {
                     if (rb.velocity.magnitude > 0)
                     {
                        rb.AddRelativeForce(Vector3.forward * (1/rb.velocity.magnitude));
                     }

                 }*/
                boatvelocity = rb.velocity.magnitude;
                rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);

            }
            if (funsyss == false)
            {

                if (rb.velocity.magnitude > 0)
                {
                    rb.drag = stopfriction;
                }
              
            }
    
        }
    
    }
}
