using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sailbehaviour : MonoBehaviour
{
    public GameObject boat;
    public GameObject sail;
    public float mixedboatangle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // its a bit clunky but works for now, this has potential
        mixedboatangle = sail.GetComponent<supersailing>().mixedboatangle;
        Debug.Log(sail.transform.localEulerAngles.y);
        if (sail.transform.localEulerAngles.y > 180)
        {
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
            //scale = 1 ok
        }
        if (sail.transform.localEulerAngles.y < 180)
        {
            //scale =-1
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
