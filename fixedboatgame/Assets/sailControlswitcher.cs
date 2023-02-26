using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sailControlswitcher : MonoBehaviour
{
    public GameObject isonboat;
    public GameObject activer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isseated = isonboat.GetComponent<fpsmovement>().funsyss;
        if (isseated)
        {
            activer.SetActive(true);
        }
        else
        {
            activer.SetActive(false);
        }
    }
}
