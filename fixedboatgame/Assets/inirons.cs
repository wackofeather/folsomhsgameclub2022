using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class inirons : MonoBehaviour
{
    public GameObject sail;
    public Color emissionblue;
    public Color emissionred;
    public Material compassblue;
    public Material[] materials;
    public float colorswitchtime;
    float velocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float bruhangle = sail.GetComponent<supersailing>().bruhangle;
        if ((bruhangle > 20) && (bruhangle < 170))
        {
      Material materiali = gameObject.GetComponent<Renderer>().material;
            /*   float tempR = Mathf.SmoothStep(materials[1].color.r, materials[0].color.r, colorswitchtime);
               float tempG = Mathf.SmoothStep(materials[1].color.g, materials[0].color.g, colorswitchtime);
               float tempB = Mathf.SmoothStep(materials[1].color.b, materials[0].color.b, colorswitchtime);*/
            if (materiali.color == materials[0].color)
            {
                materiali.EnableKeyword("_EMISSION");
                materiali.SetColor("_EmissionColor", emissionblue);
            }
          
            materiali.color = Color.Lerp(materiali.color, materials[0].color, colorswitchtime);
            // materiali.color = new Color(tempR,tempG, tempB);
        }
        if ((bruhangle < 20) | (bruhangle > 170))
        {
            Material materiali = gameObject.GetComponent<Renderer>().material;
            /* float tempR = Mathf.SmoothStep(materials[1].color.r, materials[0].color.r, colorswitchtime);
             float tempG = Mathf.SmoothStep(materials[1].color.g, materials[0].color.g, colorswitchtime);
             float tempB = Mathf.SmoothStep(materials[1].color.b, materials[0].color.b, colorswitchtime);*/
            if (materiali.color == materials[1].color)
            {
                 materiali.EnableKeyword("_EMISSION");
                materiali.SetColor("_EmissionColor",emissionred);
            }
      
            materiali.color = Color.Lerp(materiali.color, materials[1].color, colorswitchtime);
          //  gameObject.GetComponent<Renderer>().material.color = Color.Lerp(materials[0].color, )
           // gameObject.GetComponent<Renderer>().material.Lerp(materials[0], materials[1], colorswitchtime);
            // compassblue.color = new Color(0.118592f, 0.1936882f, 0.3867925f);
        }
    }
}
