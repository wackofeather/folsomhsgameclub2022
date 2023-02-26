using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class controlMaster : MonoBehaviour
{
    public GameObject sailcontrols;
    public GameObject rControl;
    public GameObject fControl;
    public GameObject player;
    public GameObject isonislandchecker;
    public GameObject boatrotater;
    public TextMeshProUGUI fcontroltext;
    bool red;
    Color textcolor;
    public float pingpongspeed;
    public Color pingcolor1;
    public Color pingcolor2;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Mathf.DeltaAngle(boatrotater.transform.eulerAngles.z, 0));
        float boatangle = Mathf.Abs(Mathf.DeltaAngle(boatrotater.transform.eulerAngles.z, 0));
        bool isInBoat = player.GetComponent<fpsmovement>().funsyss;
        bool isOnIsland = player.GetComponent<isonisland>().onisland;
        if (isInBoat)
        {
            sailcontrols.SetActive(true);
            fControl.SetActive(true);
           // rControl.SetActive(true);
            if (fcontroltext.text != "R - Lean Back")
            {
                fcontroltext.text = "R - Lean Back";
            }
            if (boatangle > 20)
            {
                //fcontroltext.color = Color.Lerp(fcontroltext.color, Color.red, 0.7f);
                if (Input.GetKey(KeyCode.R))
                {
                    red = false;
                }
                if (!Input.GetKey(KeyCode.R))
                {
                    red = true;
                }
                //red = true;
            }
            if (boatangle < 20)
            {
                //fcontroltext.color = Color.Lerp(fcontroltext.color, Color.red, 0.7f);
                red = false;
            }
        }
        if (!isInBoat)
        {
            red = false;
            if (isOnIsland)
            {
                sailcontrols.SetActive(false);
                fControl.SetActive(false);
                //rControl.SetActive(false);
            }
            if (!isOnIsland)
            {
               
              
                sailcontrols.SetActive(false);
                fControl.SetActive(true);
               // rControl.SetActive(false);
                if (fcontroltext.text == "R - Lean Back")
                {
                    fcontroltext.text = "F - Get in Boat";
                }

            }

        }
        if (fControl.activeSelf)
        {
          //  Debug.Log(red);
            if (red)
            {
                // textcolor = Color.red;
                float t = (float)((Mathf.Sin(Time.time * pingpongspeed) + 1) / 2.0);
                textcolor = Color.Lerp(pingcolor1, pingcolor2, t);
            }
            if (!red)
            {
                textcolor = Color.white;
            }

            fcontroltext.color = Color.Lerp(fcontroltext.color, textcolor, 0.1f);
        }
    }
    void FadeIn()
    {

    }
    void FadeOut()
    {

    }
}
