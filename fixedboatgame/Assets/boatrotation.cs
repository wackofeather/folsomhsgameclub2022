using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatrotation : MonoBehaviour
{
    // Start is called before the first frame update
    float boatangle = 270;
    public GameObject boat;
    public float isrotating;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        gameObject.transform.rotation = Quaternion.Euler(0f, boatangle, 0f);
        isrotating = 0;
        if (Input.GetMouseButton(0))
        {
            boatangle += 40f *Time.deltaTime;
            isrotating = 1;
        }
        if (Input.GetMouseButton(1))
        {
            boatangle -= 40f * Time.deltaTime;
            isrotating = -1;
        }

        
        
    }
}
