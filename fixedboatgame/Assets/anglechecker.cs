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
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*float angle = boat.transform.rotation.eulerAngles.y;
        float exComponent = Mathf.Cos(angle) * force;
        float yComponent = Mathf.Sin(angle) * force;

        Vector3 forward = new Vector3(-exComponent, -yComponent, 0);*/
    

        Quaternion boatangle = boat.transform.rotation;
        bool ghostsailfollow = GetComponent<supersailing>().fartsysus;
        Rigidbody rb = boat.GetComponent<Rigidbody>();
        sailanglefromzero = Mathf.Abs(Mathf.DeltaAngle(gameObject.transform.localEulerAngles.y, 0));
        bruhangle = Quaternion.Angle(boat.transform.rotation, windvector.transform.rotation);
        sailwindangle = Quaternion.Angle(gameObject.transform.rotation, windvector.transform.rotation);
        if (bruhangle > 20 && bruhangle < 40)
        {
            if ((sailanglefromzero < 20) && (ghostsailfollow == true))
            {
                rb.AddRelativeForce(Vector3.back); //sss
                Debug.Log("whataahaha");
            }
            //Debug.Log(sailwindangle);
        }
        if (bruhangle > 40 && bruhangle < 70)
        {
            if ((sailanglefromzero < 35) && (sailanglefromzero > 20) && (ghostsailfollow == true))
            {
                rb.AddRelativeForce(Vector3.back); //sss
                Debug.Log("whataahaha");
            }
            //Debug.Log(sailwindangle);
        }
        if (bruhangle > 70 && bruhangle < 100)
        {
            if ((sailanglefromzero < 45) && (sailanglefromzero > 35) && (ghostsailfollow == true))
            {
                rb.AddRelativeForce(Vector3.back); //sss
                Debug.Log("whataahaha");
            }
            //Debug.Log(sailwindangle);
        }
        if (bruhangle > 100 && bruhangle < 120)
        {
            if ((sailanglefromzero < 60) && (sailanglefromzero > 45) && (ghostsailfollow == true))
            {
                rb.AddRelativeForce(Vector3.back); //sss
                Debug.Log("whataahaha");
            }
            //Debug.Log(sailwindangle);
        }
        if (bruhangle > 120 && bruhangle < 150)
        {
            if ((sailanglefromzero < 75) && (sailanglefromzero > 60) && (ghostsailfollow == true))
            {
                rb.AddRelativeForce(Vector3.back); //sss
                Debug.Log("whataahaha");
            }
            //Debug.Log(sailwindangle);
        }
        if (bruhangle > 150 && bruhangle < 170)
        {
            if ((sailanglefromzero < 91) && (sailanglefromzero > 75) && (ghostsailfollow == true))
            {
                rb.AddRelativeForce(Vector3.back); //sss
                Debug.Log("whataahaha");
            }
            //Debug.Log(sailwindangle);
        }
        //Debug.Log(sailwindangle);

        rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
    }
}
