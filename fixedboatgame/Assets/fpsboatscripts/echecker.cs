using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class echecker : MonoBehaviour
{
    public bool issailing;
    bool issailinginstantiate;
    bool issailingstate;
    // Start is called before the first frame update
    void Start()
    {
        issailing = false;
        issailinginstantiate = true;
    }

    // Update is called once per frame
    void LateUpdate()
    {
       // Debug.Log(issailing);
        
        if (issailinginstantiate == true)
        {
            issailingstate = issailing;
            issailinginstantiate = false;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            issailing = !issailingstate;
            issailinginstantiate = true;
        }
    }
}
