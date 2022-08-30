using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomwind : MonoBehaviour
{
    float windangle = 0f;
    public float windchangeminutes;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("randangle", 0f, (windchangeminutes * 60));
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void randangle()
    {
        windangle = Random.Range(0, 360);
        
        transform.rotation = Quaternion.Euler(new Vector3(0, windangle, 0));
        float windrotation = gameObject.transform.rotation.eulerAngles.y;
        //Debug.Log(windangle);
        //Debug.Log(windrotation);
    }
}
