using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class idealslice : MonoBehaviour
{
    public GameObject sail;
    public Image circle;
    float velocity;
    public float alphaspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mixedboatangle = sail.GetComponent<supersailing>().mixedboatangle;
        float maxlet = sail.GetComponent<anglechecker>().maxlet;
        float minpull = sail.GetComponent<anglechecker>().minpull;
        float bruhangle = sail.GetComponent<supersailing>().bruhangle;
        if ((mixedboatangle > 20) && (mixedboatangle < 170))
        {
            gameObject.transform.localRotation = Quaternion.Euler(0, 0, -minpull);
            float fillamount = (maxlet-minpull) / 360;
            circle.fillAmount = fillamount;
            
        }
        if ((mixedboatangle < 340) && (mixedboatangle > 190))
        {
            gameObject.transform.localRotation = Quaternion.Euler(0, 0, maxlet);
            float fillamount = (maxlet-minpull) / 360;
            circle.fillAmount = fillamount;
        }
        Debug.Log(bruhangle);
        if ((bruhangle > 170) | (bruhangle < 20))
        {
            float tempalpha = 0;
            float smoothalpha = Mathf.SmoothDamp(circle.color.a, tempalpha, ref velocity, alphaspeed * Time.deltaTime);
            circle.color = new Color(circle.color.r, circle.color.g, circle.color.b, smoothalpha);
        }
        if ((bruhangle < 170) && (bruhangle > 20))
        {
            float tempalpha = 0.56f;
            float smoothalpha = Mathf.SmoothDamp(circle.color.a, tempalpha, ref velocity, alphaspeed * Time.deltaTime);
            circle.color = new Color(circle.color.r, circle.color.g, circle.color.b, smoothalpha);
        }
    }
}
