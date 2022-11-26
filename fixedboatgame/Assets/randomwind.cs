using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomwind : MonoBehaviour
{
    public float wavespeed;
    public float windangle = 0f;
    public float windchangeminutes;
    public Material wavewater;
    // Start is called before the first frame update
    void Start()
    {
       // InvokeRepeating("randangle", 0f, (windchangeminutes * 60)); //ACTIVATE ONCE READY
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0, windangle, 0));
        float vectorx = Mathf.Sin(Mathf.Deg2Rad * windangle) * wavespeed;
        float vectory = Mathf.Cos(Mathf.Deg2Rad * windangle) * wavespeed;
        wavewater.SetFloat("_wavevectorx", vectorx);
        wavewater.SetFloat("_wavevectory", vectory);
      // Debug.Log(wavewater.GetFloat("_wavevectory"));
    }
    public void randangle()
    {
        windangle = Random.Range(0, 360);
        
        transform.rotation = Quaternion.Euler(new Vector3(0, windangle, 0));
        float windrotation = gameObject.transform.rotation.eulerAngles.y;
        //Debug.Log(windangle);
        //Debug.Log(windrotation);
    }
}
