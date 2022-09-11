using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sailbehaviour : MonoBehaviour
{
    public GameObject boat;
    
    public float mixedboatangle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        mixedboatangle = sail.GetComponent<supersailing>().mixedboatangle;
        if ((mixedboatangle > 20) && (mixedboatangle < 170))
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);
            //scale = 1
        }
        if ((mixedboatangle < 340) && (mixedboatangle > 190))
        {
            //scale =-1
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
