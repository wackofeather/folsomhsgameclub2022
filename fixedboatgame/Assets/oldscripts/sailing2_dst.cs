using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sailing2_dst : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float scrollDir = Input.GetAxis("Mouse ScrollWheel");
        float yrotation = gameObject.transform.localEulerAngles.y;


        //float angle;
        //angle = Mathf.Clamp(yrotation, 1, 90);

        yrotation += scrollDir;

        yrotation = Mathf.Clamp(yrotation, 1f, 90f);

        

        Quaternion newrotation = Quaternion.Euler(0f, yrotation, 0f);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, newrotation, 1f);
       
    }
}
