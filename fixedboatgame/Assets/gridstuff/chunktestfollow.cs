using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chunktestfollow : MonoBehaviour
{
    public GameObject followobject;
    public float yoffset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 followvector = new Vector3(followobject.transform.position.x, 0, followobject.transform.position.z);
        gameObject.transform.position = followvector;
    }
}
