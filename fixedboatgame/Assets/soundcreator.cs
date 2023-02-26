using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class soundcreator : MonoBehaviour
{
    bool boatmovinginitialize;
    public GameObject boat;
    public GameObject player;
    public GameObject islandparent;
    // Start is called before the first frame update
    void Start()
    {
         FindObjectOfType<AudioManager>().Play("defaultocean");
          FindObjectOfType<AudioManager>().Play("seagulls");
        FindObjectOfType<AudioManager>().Play("boatmoving");
        FindObjectOfType<AudioManager>().Play("wind");
        FindObjectOfType<AudioManager>().Play("walking");
        FindObjectOfType<AudioManager>().Play("creak");
        FindObjectOfType<AudioManager>().Play("chirp");
       


    }

    // Update is called once per frame
    void Update()
    {
     
        bool ismoving = boat.GetComponent<anglechecker>().goofyahash;
        bool iswalking = player.GetComponent<fpsmovement>().iswalking;
        bool iscreaking = player.GetComponent<fpsmovement>().iscreaking;
        bool musicfadeout = player.GetComponent<isonisland>().fadeout;
        bool isonIsland = player.GetComponent<isonisland>().onisland;
        bool inBoss = islandparent.GetComponent<islandfollowattempt2>().inboss;
        if (!isonIsland)
        {
            if (inBoss)
            {

                FindObjectOfType<AudioManager>().Play("boss");
                FindObjectOfType<AudioManager>().SetVolume("music", 0f);
                FindObjectOfType<AudioManager>().SetMaxVolume("boss");
            }
            if (!inBoss)
            {
                /*FindObjectOfType<AudioManager>().SetVolume("music", 0.03f);*/
                FindObjectOfType<AudioManager>().SetVolume("boss", 0f);
           
                FindObjectOfType<AudioManager>().SetVolume("music", 0.05f);
               

            }
            FindObjectOfType<AudioManager>().SetVolume("defaultocean", 0f);
            FindObjectOfType<AudioManager>().SetVolume("chirp", 0f);
            FindObjectOfType<AudioManager>().SetMaxVolume("seagulls");
        }
      
        FindObjectOfType<AudioManager>().SetMaxVolume("wind");
        //FindObjectOfType<AudioManager>().SetMaxVolume("seagulls");
        //FindObjectOfType<AudioManager>().SetMaxVolume("defaultocean");
        
        /*  if (isonIsland)
          {
              StopCoroutine(FindObjectOfType<AudioManager>().FadeOut("defaultocean", 0.00007f, 0.075f));
              StartCoroutine(FindObjectOfType<AudioManager>().FadeIn("defaultocean", 0.00007f));

              StopCoroutine(FindObjectOfType<AudioManager>().FadeOut("chirp", 0.00007f, 0f));
              StartCoroutine(FindObjectOfType<AudioManager>().FadeIn("chirp", 0.00007f));
          }
          if (!isonIsland)
          {
              StopCoroutine(FindObjectOfType<AudioManager>().FadeIn("defaultocean", 0.00007f));
              StartCoroutine(FindObjectOfType<AudioManager>().FadeOut("defaultocean", 0.00007f, 0.075f));


              StopCoroutine(FindObjectOfType<AudioManager>().FadeIn("chirp", 0.00007f));
              StartCoroutine(FindObjectOfType<AudioManager>().FadeOut("chirp", 0.00007f, 0f));
          }*/
        if (isonIsland)
        {
            
            FindObjectOfType<AudioManager>().SetMaxVolume("defaultocean");
           
            if (musicfadeout == true)
            {
                /*  StopCoroutine(FindObjectOfType<AudioManager>().FadeIn("music", 0.00007f));
                  StartCoroutine(FindObjectOfType<AudioManager>().FadeOut("music", 0.00007f, 0f));*/
                FindObjectOfType<AudioManager>().SetVolume("music", 0f);
                FindObjectOfType<AudioManager>().SetVolume("seagulls", 0f);
                FindObjectOfType<AudioManager>().SetMaxVolume("chirp");
            }
            if (musicfadeout == false)
            {
                /* StopCoroutine(FindObjectOfType<AudioManager>().FadeOut("music", 0.00007f, 0f));
                 StartCoroutine(FindObjectOfType<AudioManager>().FadeIn("music", 0.00007f));*/
                FindObjectOfType<AudioManager>().SetMaxVolume("music");
                FindObjectOfType<AudioManager>().SetVolume("seagulls", 0.024f);
                FindObjectOfType<AudioManager>().SetVolume("chirp", 0.128f);
            }
        }
     /*   if (!isonIsland)
        {
            FindObjectOfType<AudioManager>().SetVolume("defaultocean", 0f);
            FindObjectOfType<AudioManager>().SetVolume("music", 0.03f);
            FindObjectOfType<AudioManager>().SetVolume("chirp", 0f);
            FindObjectOfType<AudioManager>().SetMaxVolume("seagulls");
        }*/
        if (ismoving)
        {
          //  Debug.Log("ismoving");

            /*  StopCoroutine(FindObjectOfType<AudioManager>().FadeOut("boatmoving", 0.0025f, 0f));
              StartCoroutine(FindObjectOfType<AudioManager>().FadeIn("boatmoving", 0.0005f));*/

            // StartCoroutine(FindObjectOfType<AudioManager>().SetVolume("boatmoving", 0));
            FindObjectOfType<AudioManager>().SetMaxVolume("boatmoving");
            boatmovinginitialize = false;
           
        }
        if (!ismoving)
        {
            //Debug.Log("no");
            boatmovinginitialize = true;
            //FindObjectOfType<AudioManager>().Stop("boatmoving");

            FindObjectOfType<AudioManager>().SetVolume("boatmoving", 0f);

        }
        if (iswalking)
        {

            /* StopCoroutine(FindObjectOfType<AudioManager>().FadeOut("walking", 0.05f, 0f));
             StartCoroutine(FindObjectOfType<AudioManager>().FadeIn("walking", 0.05f));*/
            FindObjectOfType<AudioManager>().SetMaxVolume("walking");
            // boatmovinginitialize = false;

        }
        if (!iswalking)
        {
            /// boatmovinginitialize = true;
            //FindObjectOfType<AudioManager>().Stop("boatmoving");
            /*  StopCoroutine(FindObjectOfType<AudioManager>().FadeIn("walking", 0.05f));
              StartCoroutine(FindObjectOfType<AudioManager>().FadeOut("walking", 0.05f, 0f));*/
            FindObjectOfType<AudioManager>().SetVolume("walking", 0f);

        }
        if (iscreaking)
        {

            /*StopCoroutine(FindObjectOfType<AudioManager>().FadeOut("creak", 0.05f, 0f));
            StartCoroutine(FindObjectOfType<AudioManager>().FadeIn("creak", 0.05f));*/
            FindObjectOfType<AudioManager>().SetMaxVolume("creak");
            // boatmovinginitialize = false;

        }
        if (!iscreaking)
        {
            /// boatmovinginitialize = true;
            //FindObjectOfType<AudioManager>().Stop("boatmoving");
            /*  StopCoroutine(FindObjectOfType<AudioManager>().FadeIn("creak", 0.05f));
              StartCoroutine(FindObjectOfType<AudioManager>().FadeOut("creak", 0.05f, 0f));*/
            FindObjectOfType<AudioManager>().SetVolume("creak", 0f);

        }
      



    }

}
