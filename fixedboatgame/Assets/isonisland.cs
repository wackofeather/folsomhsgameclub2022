using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isonisland : MonoBehaviour
{
    public Transform groundcheck;
    public float radius;
    public LayerMask island;
    public bool onisland;
    public GameObject chunks;
    public GameObject islandparent;
    public GameObject watersimparent;
    public GameObject watersim;
    public GameObject upobject;
    public GameObject downdis;
    bool switches;
    Vector3 up;
    Vector3 down;
    //public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
         up = upobject.transform.position;
        down = downdis.transform.position;
        switches = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        bool funsys = GetComponent<fpsmovement>().funsyss;
        onisland = Physics.CheckSphere(groundcheck.position, radius, island); //s
        //onisland = Physics.CheckCapsule(up, down, radius, island);
        bool islandinstantiated = islandparent.GetComponent<islandfollowattempt2>().islandinstantiate;
        
        if ((islandinstantiated) && (switches == false))
        {
            Debug.Log("beepboop");
            watersimparent = GameObject.Find("watersimparent");
            watersimparent.SetActive(false);
            switches = true;
          

        }
        if ((switches == true) && (islandinstantiated))
        {
            Debug.Log(onisland);
            if ((onisland) && (!funsys))
            {
                Debug.Log("on");
                chunks.SetActive(false);
                watersimparent.SetActive(true);
            }
            if ((!onisland) && (!funsys))
            {
                chunks.SetActive(true);
                Debug.Log("off");
                watersimparent.SetActive(false);
            }
     
        }
    
    }
}
