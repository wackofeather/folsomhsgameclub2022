using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sailgraphicfollow : MonoBehaviour
{
    public GameObject behindsail;
    public GameObject boatrotater;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.rotation = behindsail.transform.rotation;
        
       gameObject.transform.rotation = Quaternion.Lerp(gameObject.transform.rotation, behindsail.transform.rotation, 10 * Time.deltaTime);
    }
}
