using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sailing : MonoBehaviour
{
    
    public float sensitivity = 1000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float scrollDir = Input.GetAxis("Mouse ScrollWheel");

        if ((gameObject.transform.localEulerAngles.y > 90) && (gameObject.transform.localEulerAngles.y < 110))
        if ((gameObject.transform.rotation.eulerAngles.y > 90))
        {
            Vector3 newRotation = new Vector3(0, 90, 0);
            transform.localEulerAngles = newRotation;
        }


            transform.Rotate(new Vector3(0, (scrollDir), 0) * Time.deltaTime);

    }
}
