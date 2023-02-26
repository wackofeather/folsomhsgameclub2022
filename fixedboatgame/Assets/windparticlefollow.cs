using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windparticlefollow : MonoBehaviour
{

    public GameObject followobject;
    public GameObject wind;
    public float turntime;
    float xvel;
    float yvel;
    float zvel;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
      /*   float x = Mathf.SmoothDampAngle(transform.eulerAngles.x, wind.transform.eulerAngles.x, ref xvel, turntime * Time.deltaTime);
        float y = Mathf.SmoothDampAngle(transform.eulerAngles.y, wind.transform.eulerAngles.y, ref yvel, turntime * Time.deltaTime);*/
       float y = Mathf.SmoothDampAngle(transform.localEulerAngles.y, wind.transform.localEulerAngles.y, ref yvel, turntime * Time.deltaTime);
        Quaternion windangle = Quaternion.Euler(0, y, 0);
        gameObject.transform.localRotation = windangle;
        Vector3 follow = followobject.transform.position;
        gameObject.transform.position = follow;
    }
}
