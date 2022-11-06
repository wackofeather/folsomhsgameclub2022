using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerplatformfollow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bree;
    public GameObject boatrotater;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        /*  Quaternion shit = bree.transform.rotation;
          Vector3 goofy = shit * bree.transform.position;
          transform.position = goofy;*/
        transform.position = bree.transform.position;
        transform.rotation = boatrotater.transform.rotation;
    }
}
