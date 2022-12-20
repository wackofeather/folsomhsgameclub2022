using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class watercolorshifter : MonoBehaviour
{
    public float shiftspeed;
    public bool shift;
    public bool shiftswitch;
    bool shiftinitialize;
    public Skybox cameraskybox;
    public Material regularskybox;
    public Material bossksybox;
    public Light omnilight;
    public Light evilislandlight;
    public Color regularlight;
    public Color bosslight;
    public Material wavywater;
    public Material flatwater;
    public Material plainwater;
    [ColorUsage(true, true)]
    public Color regularcap;
    public Color regularbase;
    [ColorUsage(true, true)]
    public Color othercap;
    public Color otherbase;
    Color cap;
    Color basecolor;
    public bool bossfight;
    // Start is called before the first frame update
    void Start()
    {
        cap = regularcap;
        basecolor = regularbase;
        //
        shift = false;
        shiftswitch = true;
        bossfight = false;
    }

    // Update is called once per frame
    void Update()
    {
   /*     if (shift == true)
        {
            cap = Color.Lerp(cap, othercap, shiftspeed * Time.deltaTime);
            basecolor = Color.Lerp(basecolor, otherbase, shiftspeed * Time.deltaTime);
            wavywater.SetColor("_capcolor", cap);
            wavywater.SetColor("_basecolor", basecolor);
            flatwater.SetColor("_flatcapcolor", cap);
            flatwater.SetColor("_flatbasecolor", basecolor);
            plainwater.color = basecolor;
            shiftswitch = true;
        }
        if (!shift)
        {
            cap = Color.Lerp(cap, regularcap, shiftspeed * Time.deltaTime);
            basecolor = Color.Lerp(basecolor, regularbase, shiftspeed * Time.deltaTime);
            wavywater.SetColor("_capcolor", cap);
            wavywater.SetColor("_basecolor", basecolor);
            flatwater.SetColor("_flatcapcolor", cap);
            flatwater.SetColor("_flatbasecolor", basecolor);
            plainwater.color = basecolor;
            shiftswitch = true;
        }*/
     /*   if (Input.GetKeyDown(KeyCode.B))
        {
            
            shift = !shift;
            //
            shiftswitch = true;
        }*/
        //
        if (shiftswitch == true)
        {
            if (!shift)
            {
                bossfight = false;
                cap = Color.Lerp(cap, regularcap, shiftspeed * Time.deltaTime);
                basecolor = Color.Lerp(basecolor, regularbase, shiftspeed * Time.deltaTime);
                wavywater.SetColor("_capcolor", cap);
                wavywater.SetColor("_basecolor", basecolor);
                flatwater.SetColor("_flatcapcolor", cap);
                flatwater.SetColor("_flatbasecolor", basecolor);
                plainwater.color = basecolor;
                cameraskybox.material.Lerp(cameraskybox.material, regularskybox, shiftspeed * Time.deltaTime);
                omnilight.color = Color.Lerp(omnilight.color, regularlight, shiftspeed * Time.deltaTime);
                evilislandlight.intensity = Mathf.Lerp(evilislandlight.intensity, 0, shiftspeed * Time.deltaTime);
                if ((basecolor == regularbase) && (cap == regularcap) && (cameraskybox.material == regularskybox) && (omnilight.color == bosslight))
                {
                   /* bosslight.SetActive(false);
                    regularlight.SetActive(true);*/
                    shiftswitch = false;
                }
            }
            if (shift)
            {
                bossfight = true;
                cap = Color.Lerp(cap, othercap, shiftspeed * Time.deltaTime);
                basecolor = Color.Lerp(basecolor, otherbase, shiftspeed * Time.deltaTime);
                wavywater.SetColor("_capcolor", cap);
                wavywater.SetColor("_basecolor", basecolor);
                flatwater.SetColor("_flatcapcolor", cap);
                flatwater.SetColor("_flatbasecolor", basecolor);
                plainwater.color = basecolor;
                cameraskybox.material.Lerp(cameraskybox.material, bossksybox, shiftspeed * Time.deltaTime);
                omnilight.color = Color.Lerp(omnilight.color, bosslight, shiftspeed * Time.deltaTime);
                evilislandlight.intensity = Mathf.Lerp(evilislandlight.intensity, 1, shiftspeed * Time.deltaTime);
                if ((basecolor == otherbase) && (cap == othercap) && (cameraskybox.material == bossksybox) && (omnilight.color == bosslight))
                {
                 /*   bosslight.SetActive(true);
                    regularlight.SetActive(false);*/
                    shiftswitch = false;
                }
            }
        }
    }
}
