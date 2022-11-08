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
    // Start is called before the first frame update
    void Start()
    {
        goofyahash = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        /*float angle = boat.transform.rotation.eulerAngles.y;
        float exComponent = Mathf.Cos(angle) * force;
        float yComponent = Mathf.Sin(angle) * force;

        Vector3 forward = new Vector3(-exComponent, -yComponent, 0);*/
        bool funsyss = player.GetComponent<fpsmovement>().funsyss;

        Quaternion boatangle = boat.transform.rotation;
        bool ghostsailfollow = GetComponent<supersailing>().fartsysus;
        Rigidbody rb = boat.GetComponent<Rigidbody>();
        sailanglefromzero = Mathf.Abs(Mathf.DeltaAngle(gameObject.transform.localEulerAngles.y, 0));
        bruhangle = Quaternion.Angle(boat.transform.rotation, windvector.transform.rotation);
        sailwindangle = Quaternion.Angle(gameObject.transform.rotation, windvector.transform.rotation);
        //rb.AddForce(Vector3.down * gravity);
        if (funsyss == true)
        {
            if (bruhangle > 20 && bruhangle < 40)
            {
                if ((sailanglefromzero < 20) && (ghostsailfollow == true))
                {
                    rb.AddRelativeForce(Vector3.back * force, ForceMode.VelocityChange); //ssss
                                                                                         //Debug.Log("whataahaha");
                    goofyahash = true;
                }
                else
                {
                    goofyahash = false;
                }
                //Debug.Log(sailwindangle);
            }
            if (bruhangle > 40 && bruhangle < 70)
            {
                if ((sailanglefromzero < 35) && (sailanglefromzero > 20) && (ghostsailfollow == true))
                {
                    rb.AddRelativeForce(Vector3.back * force, ForceMode.VelocityChange); //sss
                                                                                         // Debug.Log("whataahaha");
                    goofyahash = true;
                }
                else
                {
                    goofyahash = false;
                }
                //Debug.Log(sailwindangle);
            }
            if (bruhangle > 70 && bruhangle < 100)
            {
                if ((sailanglefromzero < 45) && (sailanglefromzero > 35) && (ghostsailfollow == true))
                {
                    rb.AddRelativeForce(Vector3.back * force, ForceMode.VelocityChange); //sss
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
                if ((sailanglefromzero < 60) && (sailanglefromzero > 45) && (ghostsailfollow == true))
                {
                    rb.AddRelativeForce(Vector3.back * force, ForceMode.VelocityChange); //sss
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
                if ((sailanglefromzero < 75) && (sailanglefromzero > 60) && (ghostsailfollow == true))
                {
                    rb.AddRelativeForce(Vector3.back * force, ForceMode.VelocityChange); //sss
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
                if ((sailanglefromzero < 91) && (sailanglefromzero > 75) && (ghostsailfollow == true))
                {
                    rb.AddRelativeForce(Vector3.back * force, ForceMode.VelocityChange); //sss
                                                                                         //Debug.Log("whataahaha");
                    goofyahash = true;
                }
                else
                {
                    goofyahash = false;
                }
                //Debug.Log(sailwindangle);
            }
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
