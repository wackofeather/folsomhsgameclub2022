using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafolowtest : MonoBehaviour
{
    public GameObject ship;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 shehsha = new Vector3(ship.transform.position.x, transform.position.y, ship.transform.position.z);
        transform.position = shehsha;
    }
}
