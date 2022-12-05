using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class sailcolorchange : MonoBehaviour
{
    public GameObject sail;
    public Image sailui;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool ispowered = sail.GetComponent<anglechecker>().goofyahash;
        if (ispowered)
        {
            sailui.color = new Color(0, 0.490566f, 0.3517266f); //0.2075472f, 0.1475891f
        }
        if (!ispowered)
        {
            sailui.color = new Color(0, 0, 0);
        }
        //0,80,11

    }
}
