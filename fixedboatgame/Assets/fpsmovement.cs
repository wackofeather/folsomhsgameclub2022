using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsmovement : MonoBehaviour
{
    public CharacterController charcontroller;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        charcontroller.Move(move * speed * Time.deltaTime);
    }
}
