using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class anglechecker : MonoBehaviour
{
    public GameObject windvector;
    public float sailwindangle;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        sailwindangle = Quaternion.Angle(gameObject.transform.rotation, windvector.transform.rotation);
        //Debug.Log(sailwindangle);
        
    }
}
