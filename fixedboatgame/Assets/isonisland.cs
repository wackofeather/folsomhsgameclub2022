using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class isonisland : MonoBehaviour
{
    public Transform groundcheck;
    public float radius;
    public LayerMask island;
    public bool onisland;
    public GameObject chunks;
    public GameObject islandparent;
    public GameObject watersimparent;
    public ParticleSystem wind1;
    public ParticleSystemStopBehavior howwindstops;
    public GameObject watersim;
    public GameObject upobject;
    public GameObject downdis;
    bool switches;
    Vector3 up;
    Vector3 down;
    public ParticleSystem sailingwinds;
    public Image transitioner;
    public float starttransitiondistance;
    public float endtransitiondistance;
    public GameObject shadowgod;
    public float startingalpha;
    public float endingalpha;
    float m;
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
            wind1 = GameObject.Find("wind1").GetComponent<ParticleSystem>();
            watersimparent.SetActive(false);
            shadowgod = GameObject.Find("island5oohahh");
            m = (startingalpha - endingalpha) / (starttransitiondistance-endtransitiondistance);
            switches = true;
          

        }
        if ((switches == true) && (islandinstantiated))
        {
            //Debug.Log(onisland);
            if ((onisland) && (!funsys))
            {
                
                //Debug.Log("on");
                chunks.SetActive(false);
                watersimparent.SetActive(true);
                sailingwinds.Stop(true, howwindstops);
                wind1.Play(true);
                
            }
            if ((!onisland) && (!funsys))
            {
               
                chunks.SetActive(true);
               // Debug.Log("off");
                watersimparent.SetActive(false);
                wind1.Stop(true, howwindstops);
                sailingwinds.Play(true);
               
            }
     
        }
        if (onisland)
        {
            float distance = Vector3.Distance(shadowgod.transform.position, gameObject.transform.position);//Mathf.Abs(shadowgod.transform.position.x - gameObject.transform.position.x);
           // Debug.Log(distance);
            if (distance <= starttransitiondistance)
            {
                float alpha = m * (distance-endtransitiondistance) + endingalpha;
                float alphaplugin = Mathf.Clamp(alpha, 0, 1);
                Debug.Log(alpha);
                transitioner.color = new Color(transitioner.color.r, transitioner.color.g, transitioner.color.b, alphaplugin);
            }
        }
    
    }
}
