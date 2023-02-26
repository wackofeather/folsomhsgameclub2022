using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flagfollow : MonoBehaviour
{
    public GameObject followobject;
    public GameObject wind;
    public float lerptime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Quaternion windangle = Quaternion.Euler(transform.eulerAngles.x, wind.transform.eulerAngles.y, transform.eulerAngles.z);
        gameObject.transform.rotation = Quaternion.Lerp(gameObject.transform.rotation, windangle, lerptime);
        Vector3 follow = followobject.transform.position;
        gameObject.transform.position = follow;
    }
}
