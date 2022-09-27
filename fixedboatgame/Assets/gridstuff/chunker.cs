using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class chunker : MonoBehaviour
{
    GameObject currentchunk;
    bool ahaha;
    public GameObject tiler;
    RaycastHit checkhit;
    GameObject checkedchunk;
    // Start is called before the first frame update
    void Awake()
    {
        //List<GameObject> oldtiles = tiler.GetComponent<GridGenerator>().oldtiles;
    }
    void Start()
    {
        ahaha = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
        if (ahaha == true)
        {
            //Debug.Log("meme");
            RaycastHit hit;
            Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, Mathf.Infinity);
            currentchunk = hit.transform.gameObject;
            ahaha = false;
        }
        if (ahaha == false)
        {
            Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out checkhit, Mathf.Infinity);
            checkedchunk = checkhit.transform.gameObject;
        }
        if ((checkedchunk) != currentchunk)
        {
            //Debug.Log("gaws ");
            ahaha = true;
        }
        Debug.Log(currentchunk);



    }
       /* Debug.Log(GameObject.FindWithTag("Grid"));*/
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
