using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatrotation : MonoBehaviour
{
    // Start is called before the first frame update
    float boatangle = 270;
    public GameObject boat;
    public float isrotating;
    public GameObject player;
    bool funsyss;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

      
        /*if (issailing == true)
        {*/
        if (funsyss == true)
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
          
        /*}*/
        

        
        
    }
    private void LateUpdate()
    {
        funsyss = player.GetComponent<fpsmovement>().funsyss;
    }
}
