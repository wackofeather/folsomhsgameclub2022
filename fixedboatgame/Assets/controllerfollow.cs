using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllerfollow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject charcontroller;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        charcontroller.transform.position = gameObject.transform.position;
    }
}
