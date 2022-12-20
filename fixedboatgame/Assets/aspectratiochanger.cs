using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
public class aspectratiochanger : MonoBehaviour
{
    bool switchtest;
    // public Camera camerash;
    /*  public GameObject blackbar1;
      public GameObject blackbar2;*/
    public RectTransform blackbar1;
    public RectTransform blackbar2;
    public RectTransform start1;
    public RectTransform start2;
    public RectTransform end1;
    public RectTransform end2;
    void Start()
    {
        
        switchtest = false;
    }
    //915 is right edge
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            Debug.Log("yes");
            switchtest = !switchtest;
        }
        if (switchtest == false)
        {
            blackbar1.Translate(start1.transform.position);
            blackbar2.Translate(start2.transform.position);
            // camerash.aspect = 4f / 3f;
        }
        if (switchtest == true)
        {
            blackbar1.Translate(start1.transform.position);
            blackbar2.Translate(start2.transform.position);
            //  camerash.aspect = 16f / 9f;
        }
    }
}
