using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerplatformrotatefollow : MonoBehaviour
{
    public GameObject boat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 boatfollow = new Vector3(boat.transform.position.x, boat.transform.position.y, boat.transform.position.z);
        Quaternion boatrotation = Quaternion.Euler(0, boat.transform.localEulerAngles.y, 0);
        gameObject.transform.rotation = boatrotation;
        boat.transform.position = boatfollow;
    }
}
