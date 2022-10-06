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
        
        Rigidbody rb = boat.GetComponent<Rigidbody>();
        sailanglefromzero = Mathf.Abs(Mathf.DeltaAngle(gameObject.transform.localEulerAngles.y, 0));
        bruhangle = Quaternion.Angle(boat.transform.rotation, windvector.transform.rotation);
        sailwindangle = Quaternion.Angle(gameObject.transform.rotation, windvector.transform.rotation);
        if (bruhangle > 20 && bruhangle < 40)
        {
            if (sailanglefromzero < 30)
            {
                rb.AddForce(forward); //sss
                Debug.Log("whataahaha");
            }
            Debug.Log(sailwindangle);
        }
        //Debug.Log(sailwindangle);
        
        
    }
}
