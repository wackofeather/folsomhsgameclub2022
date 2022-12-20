using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectionboxfollow : MonoBehaviour
{
    public GameObject boat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = boat.transform.position;
    }
}
