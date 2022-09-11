using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class papersailfollow : MonoBehaviour
{
    public GameObject boom;
    Quaternion paperfollow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(boom.transform.localEulerAngles.y); 
    }
}
