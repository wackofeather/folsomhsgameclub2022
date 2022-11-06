using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sailbehaviour : MonoBehaviour
{
    public GameObject boat;
    public GameObject sail;
    public float mixedboatangle;
    float velocity = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool ispowered = sail.GetComponent<anglechecker>().goofyahash;
        // its a bit clunky but works for now, this has potential
        mixedboatangle = sail.GetComponent<supersailing>().mixedboatangle;
       // Debug.Log(sail.transform.localEulerAngles.y);
        if (sail.transform.localEulerAngles.y < 180)
        {
            if (ispowered == true)
            {
                float sailscale = Mathf.SmoothDamp(gameObject.transform.localScale.x, 1, ref velocity, 0.3f);
                gameObject.transform.localScale = new Vector3(sailscale, 1, 1);
            }
            else
            {
                float sailscale = Mathf.SmoothDamp(gameObject.transform.localScale.x, 0.3f, ref velocity, 0.3f);
                gameObject.transform.localScale = new Vector3(sailscale, 1, 1);
            }
           
            //scale = 1 ok
        }
        if (sail.transform.localEulerAngles.y > 180)
        {
            if (ispowered == true)
            {
                float sailscale = Mathf.SmoothDamp(gameObject.transform.localScale.x, -1, ref velocity, 0.3f);
                gameObject.transform.localScale = new Vector3(sailscale, 1, 1);
                
            }
            else
            {
                float sailscale = Mathf.SmoothDamp(gameObject.transform.localScale.x, -0.3f, ref velocity, 0.3f);
                gameObject.transform.localScale = new Vector3(sailscale, 1, 1);
            }

        }
    }
}
