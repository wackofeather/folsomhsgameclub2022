using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flagfollow : MonoBehaviour
{
    public GameObject followobject;
    public GameObject wind;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Quaternion windangle = Quaternion.Euler(wind.transform.rotation.x, wind.transform.rotation.y, wind.transform.rotation.z);
        gameObject.transform.rotation = windangle;
        Vector3 follow = followobject.transform.position;
        gameObject.transform.position = follow;
    }
}
