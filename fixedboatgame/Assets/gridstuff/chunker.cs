using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class chunker : MonoBehaviour
{
    GameObject currentchunk;
    bool ahaha;
    public GameObject target;
    public GameObject tiler;
    RaycastHit checkhit;
    GameObject checkedchunk;
    public GameObject generator;
    public GameObject gridprefab;
    public float xSpace;
    public float zSpace;
    public GameObject parent;
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




        if ((ahaha == true) && (generator.GetComponent<GridGenerator>().gridinstantiate == false))
        {
            //Debug.Log("meme");
            RaycastHit hit;
            Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, Mathf.Infinity);
            if (hit.collider != null)
            {
                currentchunk = hit.transform.gameObject;
            }
           /* if (hit.collider == null)
            {
                GameObject bruh = Instantiate(gridprefab, gameObject.tra)
                currentchunk = 
            }*/
            
            //target.transform.position = gameObject.transform.position; //s
            ahaha = false;
        }
        if (ahaha == false)
        {
            RaycastHit hit2;
            Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit2, Mathf.Infinity);
            //Debug.Log(hit2.collider);
            if (hit2.collider != null)
            {
                
                checkedchunk = hit2.transform.gameObject;//s
            }
            
            
        }
        if ((checkedchunk) != currentchunk)
        {
            List<GameObject> oldtiles = generator.GetComponent<GridGenerator>().oldtiles;
            Debug.Log("gaws ");
            if (checkedchunk.transform.position.x > currentchunk.transform.position.x)
            {
                Debug.Log("ahhhhhhh"); //s
                float columnLength = generator.GetComponent<GridGenerator>().columnLength;
                GameObject anag = Instantiate(gridprefab, new Vector3(currentchunk.transform.position.x + xSpace + (xSpace * (2 % columnLength)), currentchunk.transform.position.y, currentchunk.transform.position.z), Quaternion.identity);
                oldtiles.Add(anag);
                anag.transform.parent = parent.transform;
                for (int i = 0; i < Mathf.Floor((generator.GetComponent<GridGenerator>().rowLength) / 2); i++)
                {

                    GameObject anagas = Instantiate(gridprefab, new Vector3(currentchunk.transform.position.x + xSpace + (xSpace * (2 % columnLength)), currentchunk.transform.position.z, currentchunk.transform.position.z - zSpace - (zSpace * (i % columnLength))), Quaternion.identity);
                    oldtiles.Add(anagas);
                    anagas.transform.parent = parent.transform;
                    GameObject anaga = Instantiate(gridprefab, new Vector3(currentchunk.transform.position.x + xSpace + (xSpace * (2 % columnLength)), currentchunk.transform.position.z, currentchunk.transform.position.z + zSpace + (zSpace * (i % columnLength))), Quaternion.identity); //Mathf.Ceil((generator.GetComponent<GridGenerator>().columnLength) / 2)
                    oldtiles.Add(anaga);
                    anaga.transform.parent = parent.transform;
                    for (int j = 0; j < (generator.GetComponent<GridGenerator>().oldtiles).Count; j++)
                    {
                       
                        if ((oldtiles[j].gameObject != null) && (Mathf.Abs(oldtiles[j].gameObject.transform.localPosition.x-currentchunk.transform.localPosition.x) >= 30)) //s
                        {
                            GameObject ahaaaaa = oldtiles[j].gameObject;
                            oldtiles.RemoveAt(j);
                            Destroy(ahaaaaa);
                        }
                    }
                    GameObject anagan = Instantiate(gridprefab, new Vector3(currentchunk.transform.position.x + xSpace + (xSpace * (2 % columnLength)), currentchunk.transform.position.z, currentchunk.transform.position.z + zSpace + (zSpace * (i % columnLength))), Quaternion.identity);
                    oldtiles.Add(anagan);
                    anagan.transform.parent = parent.transform;
                }
            }
            ahaha = true;
            
        }
        //Debug.Log(currentchunk);



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
