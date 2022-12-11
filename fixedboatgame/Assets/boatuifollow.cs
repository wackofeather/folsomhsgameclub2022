using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatuifollow : MonoBehaviour
{
    public GameObject boat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Quaternion boatrotation = Quaternion.Euler(0, 0, boat.transform.localEulerAngles.y);
        //Debug.Log(boat.transform.localEulerAngles.y);
        gameObject.transform.localRotation = boatrotation;
    }
}
