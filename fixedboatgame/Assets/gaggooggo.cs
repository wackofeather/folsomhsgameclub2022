using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gaggooggo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, 10, 0) * Time.deltaTime);
    }
}
