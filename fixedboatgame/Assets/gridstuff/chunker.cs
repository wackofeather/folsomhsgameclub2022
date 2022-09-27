using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chunker : MonoBehaviour
{
    GameObject currentchunk;
    bool ahaha;
    public GameObject tiler;
    // Start is called before the first frame update
    void Awake()
    {
        List<GameObject> oldtiles = tiler.GetComponent<GridGenerator>().oldtiles;
    }
    void Start()
    {
        ahaha = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(GameObject.FindWithTag("Grid"));
       /* if (ahaha == true)
        {
            currentchunk = GameObject.FindWithTag("Grid");
            Debug.Log("whatehec");
            ahaha = false;
        }
        if (GameObject.FindWithTag("Grid") != currentchunk)
        {
            Debug.Log("gaws ");
            ahaha = true;
        }*/

        
    }
    /*private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "gridprefab(Clone)")
        {
            Debug.Log("ahagahaga");
            if (ahaha == true)
            {
                currentchunk = other.gameObject;
                Debug.Log("whatehec");
                ahaha = false;
            }
            if (other.gameObject != currentchunk)
            {
                Debug.Log("gaws ");
                ahaha = true;
            }
        }
        
        
    }*/
}
