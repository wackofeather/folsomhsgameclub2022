using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class sailing2 : MonoBehaviour
{

    public float sensitivity = 1000;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        // Compute the sin position.
        float rotation = Input.GetAxis("Mouse ScrollWheel");

        // Now compute the Clamp value.
        float sailrotate = Mathf.Clamp(rotation, -90, 90);

        rotation = gameObject.transform.eulerAngles.y;


        
        transform.Rotate(new Vector3(0, (sailrotate * sensitivity), 0) * Time.deltaTime);

    }
}
