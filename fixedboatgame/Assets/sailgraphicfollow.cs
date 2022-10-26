using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sailgraphicfollow : MonoBehaviour
{
    public GameObject behindsail;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion.Lerp(gameObject.transform.rotation, behindsail.transform.rotation, 0.1f);
    }
}
