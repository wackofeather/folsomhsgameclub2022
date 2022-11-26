using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundcreator : MonoBehaviour
{
    bool boatmovinginitialize;
    public GameObject boat;
    // Start is called before the first frame update
    void Start()
    {
         FindObjectOfType<AudioManager>().Play("defaultocean");
          FindObjectOfType<AudioManager>().Play("seagulls");
        FindObjectOfType<AudioManager>().Play("boatmoving");
        FindObjectOfType<AudioManager>().Play("wind");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bool ismoving = boat.GetComponent<anglechecker>().goofyahash;
        
        if (ismoving)
        {

            StopCoroutine(FindObjectOfType<AudioManager>().FadeOut("boatmoving"));
            StartCoroutine(FindObjectOfType<AudioManager>().FadeIn("boatmoving"));
                boatmovinginitialize = false;
           
        }
        if (!ismoving)
        {
            boatmovinginitialize = true;
            //FindObjectOfType<AudioManager>().Stop("boatmoving");
            StopCoroutine(FindObjectOfType<AudioManager>().FadeIn("boatmoving"));
            StartCoroutine(FindObjectOfType<AudioManager>().FadeOut("boatmoving"));

        }
    }

}
