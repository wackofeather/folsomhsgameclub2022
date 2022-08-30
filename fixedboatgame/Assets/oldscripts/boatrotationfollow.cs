using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatrotationfollow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pivot;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pivot.transform.rotation = Quaternion.identity;
        transform.rotation = Quaternion.identity;   
    }
}
