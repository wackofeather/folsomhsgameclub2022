using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ruddershift : MonoBehaviour
{
    public GameObject boat;
    public float shiftspeed;
    public Quaternion left;
    public Quaternion right;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float isrotating = boat.GetComponent<boatrotation>().isrotating;
        if (isrotating == 0)
        {
            gameObject.transform.localRotation = Quaternion.Lerp(gameObject.transform.localRotation, Quaternion.identity, shiftspeed * Time.deltaTime);
        }
        if (isrotating == 1)
        {
            gameObject.transform.localRotation = Quaternion.Lerp(gameObject.transform.localRotation, left, shiftspeed * Time.deltaTime);
        }
        if (isrotating == -1)
        {
            gameObject.transform.localRotation = Quaternion.Lerp(gameObject.transform.localRotation, right, shiftspeed * Time.deltaTime);
        }
    }
}
