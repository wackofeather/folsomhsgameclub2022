using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerplatformfollow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bree;
    public GameObject boatrotater;
    public GameObject player;
    bool isonboat;
    void Start()
    {
        
    }
    //update fixes wierd collisoon but makes the player not move w/ boat
    // Update is called once per frame
    void Update()
    {
        isonboat = player.GetComponent<fpsmovement>().funsyss;
        if (isonboat)
        {
            transform.position = bree.transform.position;
            transform.rotation = boatrotater.transform.rotation;
        }
    }
    void FixedUpdate()
    {
        if (!isonboat)
        {
            transform.position = bree.transform.position;
            transform.rotation = boatrotater.transform.rotation;
       }
        /*  Quaternion shit = bree.transform.rotation;
          Vector3 goofy = shit * bree.transform.position;
          transform.position = goofy;*/
       
        
    }
}
