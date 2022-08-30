using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetest : MonoBehaviour
{
    public float speed = 0.1f;




    // Update is called once per frame
    void FixedUpdate()
    {
        float xDir = Input.GetAxis("Horizontal");
        float zDir = Input.GetAxis("Vertical");


        Vector3 direction = new Vector3(xDir, 0.0f, zDir);

        transform.position += direction * speed;


    }
}
