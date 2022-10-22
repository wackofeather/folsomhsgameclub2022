using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidbodyfps : MonoBehaviour
{
    public float speed;
    public float gravity = -9.81f;
    Vector3 velocity;
    public Transform groundcheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public float jumpheight = 3f;
    bool grounded;
    public LayerMask boatground;
    bool boated;
    public GameObject boatparent;
    public GameObject child;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        grounded = Physics.CheckSphere(groundcheck.position, groundDistance, groundMask);
        //Debug.Log(grounded);

        if (grounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        if (Input.GetButtonDown("Jump") && grounded)
        {
            velocity.y = Mathf.Sqrt(jumpheight * -2 * gravity);
        }
        Vector3 move = transform.right * x + transform.forward * z;
        /*charcontroller.Move(Vector3.Normalize(move) * speed * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        charcontroller.Move(velocity * Time.deltaTime);*/
        rb.AddForce(Vector3.Normalize(move) * speed * Time.deltaTime, ForceMode.Force);
        velocity.y += gravity * Time.deltaTime;
    }
}
