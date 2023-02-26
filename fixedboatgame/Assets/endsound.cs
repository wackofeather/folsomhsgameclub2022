using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endsound : MonoBehaviour
{
 /*   bool boatmovinginitialize;
    public GameObject boat;*/
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        /*FindObjectOfType<AudioManager>().Play("defaultocean");
        FindObjectOfType<AudioManager>().Play("seagulls");
        FindObjectOfType<AudioManager>().Play("boatmoving");
        FindObjectOfType<AudioManager>().Play("wind");*/
        FindObjectOfType<AudioManager>().Play("walkings");
    }

    // Update is called once per frame
    void FixedUpdate()
    {

       /* bool ismoving = boat.GetComponent<anglechecker>().goofyahash;*/
        bool iswalking = player.GetComponent<endingfpsmovement>().iswalking;
       // bool musicfadeout = player.GetComponent<isonisland>().fadeout;
      /*  if (ismoving)
        {

            StopCoroutine(FindObjectOfType<AudioManager>().FadeOut("boatmoving", 0.0025f));
            StartCoroutine(FindObjectOfType<AudioManager>().FadeIn("boatmoving", 0.0005f));
            boatmovinginitialize = false;

        }
        if (!ismoving)
        {
            boatmovinginitialize = true;
            //FindObjectOfType<AudioManager>().Stop("boatmoving");
            StopCoroutine(FindObjectOfType<AudioManager>().FadeIn("boatmoving", 0.0005f));
            StartCoroutine(FindObjectOfType<AudioManager>().FadeOut("boatmoving", 0.0025f));

        }*/
        if (iswalking)
        {
           // FindObjectOfType<AudioManager>().Play("walkings");
            StopCoroutine(FindObjectOfType<AudioManager>().FadeOut("walkings", 0.05f, 0f));
            StartCoroutine(FindObjectOfType<AudioManager>().FadeIn("walkings", 0.05f));
            // boatmovinginitialize = false;

        }
        if (!iswalking)
        {
           // FindObjectOfType<AudioManager>().Stop("walkings");
            /// boatmovinginitialize = true;
            //FindObjectOfType<AudioManager>().Stop("boatmoving");
              StopCoroutine(FindObjectOfType<AudioManager>().FadeIn("walkings", 0.05f));
              StartCoroutine(FindObjectOfType<AudioManager>().FadeOut("walkings", 0.05f, 0f));

        }
     /*   if (musicfadeout == true)
        {
            StopCoroutine(FindObjectOfType<AudioManager>().FadeIn("music", 0.00007f));
            StartCoroutine(FindObjectOfType<AudioManager>().FadeOut("music", 0.00007f));
        }
        if (musicfadeout == false)
        {
            StopCoroutine(FindObjectOfType<AudioManager>().FadeOut("music", 0.00007f));
            StartCoroutine(FindObjectOfType<AudioManager>().FadeIn("music", 0.00007f));
        }*/


    }
}
