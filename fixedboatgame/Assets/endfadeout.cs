using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class endfadeout : MonoBehaviour
{
    public GameObject fadeouttrigger;
    public Image panel;
    float fadevelocity;
    public float fadetime;
    float a;
    public string creditscene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool fadeout = fadeouttrigger.GetComponent<mouselookend>().fadeout;
        if (!fadeout)
        {
            a = 0;
        }
        if (fadeout)
        {
            a = Mathf.SmoothDamp(a, 1, ref fadevelocity, fadetime * Time.deltaTime);
            panel.color = new Color(panel.color.r, panel.color.g, panel.color.b, a);
            if (Mathf.Abs(panel.color.a - 1) < 0.01f)
            {
                SceneManager.LoadScene(creditscene);
            }
        }
    }
}
