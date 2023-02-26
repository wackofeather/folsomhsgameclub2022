using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using DG.Tweening;
public class uiwindfollow : MonoBehaviour
{
    public GameObject wind;
    public GameObject boat;
    float xvel;
    float yvel;
    float zvel;
    public float turntime;
    public RectTransform selfobject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       /* float x = Mathf.SmoothDampAngle(transform.eulerAngles.x, wind.transform.eulerAngles.x, ref xvel, turntime * Time.deltaTime);
        float y = Mathf.SmoothDampAngle(transform.eulerAngles.y, wind.transform.eulerAngles.y, ref yvel, turntime * Time.deltaTime);*/
        float z = Mathf.SmoothDampAngle(transform.localEulerAngles.z,(wind.transform.eulerAngles.y - boat.transform.eulerAngles.y), ref zvel, turntime * Time.deltaTime);
        Quaternion windangle = Quaternion.Euler(0, 0, z);
        //Debug.Log(windangle.eulerAngles.z);
        selfobject.transform.localRotation = windangle;
        
    }
}
