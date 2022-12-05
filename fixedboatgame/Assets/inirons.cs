using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class inirons : MonoBehaviour
{
    public GameObject sail;
    public Material compassblue;
    public Material[] materials;
    public float colorswitchtime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float bruhangle = sail.GetComponent<supersailing>().bruhangle;
        if ((bruhangle > 20) && (bruhangle < 170))
        {
            
          //  compassblue.color = new Color(0.118592f, 0.1936882f, 0.3867925f);
            Material materiali = gameObject.GetComponent<Renderer>().material;
            materiali.Lerp(materials[1], materials[0], colorswitchtime);
        }
        if ((bruhangle < 20) | (bruhangle > 170))
        {
            Material materiali = gameObject.GetComponent<Renderer>().material;
            materiali.Lerp(materials[0], materials[1], colorswitchtime);
           // gameObject.GetComponent<Renderer>().material.Lerp(materials[0], materials[1], colorswitchtime);
            // compassblue.color = new Color(0.118592f, 0.1936882f, 0.3867925f);
        }
    }
}
