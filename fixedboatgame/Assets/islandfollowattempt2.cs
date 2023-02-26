using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class islandfollowattempt2 : MonoBehaviour
{
    public LayerMask boatground;
    public float initialdowndistance;
    public float endingdowndistance;
    bool isfar;
    float boatstartx;
    float boatstarty;
    public float thetascale;
    public GameObject islandprefab;
    public Transform islanddiamtercheck;
    GameObject sheeshjk;
    public GameObject parent;
    public GameObject boat;
    Quaternion keyrotation;
    float diametercutoff;
  //  public float OGartificialdistance;
    public float OGad;
    public float artificialdistance;
    public float distance;
    public float memecutoff;
    public float cutoff;
    public float islanddiameter;
    public Rigidbody boatrigidbody;
    public float endscale;
    public float initialscale;
    public bool islandinstantiate;
    bool keepscaling;
    public float donottypevaluesdownhere;
    float scale;
    float xvelocity;
    float zvelocity;
    public GameObject islandtrackerflow;
    bool realcheck;
    public GameObject target;
    
    public float bossfightinitialdistance;
    public float bossfightenddistance;
    public bool inboss;
    public bool beforeboss;
    public bool afterboss;
    public GameObject camerash;
    float randomTimer;
    public float mintimemins;
    public float maxtimemins;
    public GameObject player;
    public float maxartificialdistance;
    Vector3 jellyvel;
    public float jellyfloat;

    bool funsys;
    public GameObject gameoverscreen;
    public GameObject savemanager;
    public bool hasdied;
    public GameObject respawnspot;
    public float deathtime;
    public GameObject boatroatter;
    public bool middlebehavior;
    public string beginning;
    public string middle;
    public string end;
    public string before;
    public string now;
    // Start is called before the first frame update
    void Awake()
    {
        before = "null";
        now = "null";
        beforeboss = false;
        inboss = false;
        afterboss = false;
       // Debug.Log("meme");
       // DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        if (Time.realtimeSinceStartup <= 15)
        {
            hasdied = false;
            
        }
        if (Time.realtimeSinceStartup < 15)
        {
            hasdied = SaveSystem.Load().hasdied;

        }
       if (middlebehavior)
        {
            SpawnIsland();
        }
      /*  if (hasdied)
        {
            artificialdistance = SaveSystem.Load().distance;
            if (SaveSystem.Load().island)
            {
                SpawnIsland();
                islandinstantiate = true;
            }
        }*/
        //artificialdistance = XMLManager.instance.LoadScores();
        randomTimer = Random.Range(mintimemins, maxtimemins);
        //Debug.Log(randomTimer);
       
      /*  Leaderboard ah = XMLManager.instance.LoadScores();
        artificialdistance = ah.distancesaved;
        islandinstantiate = ah.islandon;*/
        realcheck = true;
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      /*  Debug.Log("before is" + before);
        Debug.Log("now is" + now);*/
       // Debug.Log(hasdied);
        //Debug.LogAssertion(XMLManager.instance.leaderboard.distancesaved);
        if (player == null)
        {
            player = GameObject.Find("sidfpscontroller");
        }
        if (boat == null)
        {
            boat = GameObject.Find("propersailboatparent");
        }
        if (camerash == null)
        {
            camerash = GameObject.Find("sidfpscontroller");
        }
        if (boatrigidbody == null)
        {
            boatrigidbody = boat.GetComponent<Rigidbody>();
        }
       // Debug.Log(keepscaling);
      //  Debug.Log(scale);
      if (islandinstantiate == false)
        {
            if (player != null)
            {
                funsys = player.GetComponent<fpsmovement>().funsyss;
            }
            
            if (funsys)
            {
                randomTimer -= Time.deltaTime;
            }
           if (!middlebehavior)
            {
                if (randomTimer <= 0)
                {
                    if ((camerash.transform.eulerAngles.y < 30) | (camerash.transform.eulerAngles.y > 330))
                    {
                        //Debug.Log("withinrange");


                        SpawnIsland();
                        // islandinstantiate = true;

                    }
                }
            }
          
          
        }
  
        if (islandinstantiate == true)
        {
            if ((artificialdistance > bossfightinitialdistance))
            {
                target.GetComponent<watercolorshifter>().shift = false;
                target.GetComponent<watercolorshifter>().shiftswitch = true;
                if (inboss == true)
                {
                    before = "middle";
                    inboss = false;
                }
                
                beforeboss = true;
                afterboss = false;
                now = "beginning";

            }
            //Debug.Log(artificialdistance);
            if ((artificialdistance > bossfightenddistance) && (artificialdistance < bossfightinitialdistance))
            {
                target.GetComponent<watercolorshifter>().shift = true;
                target.GetComponent<watercolorshifter>().shiftswitch = true;
                if (beforeboss == true)
                {
                    before = "beginning";
                    beforeboss = false;
                }
                if (afterboss == true)
                {
                    before = "end";
                    afterboss = false;
                }
                inboss = true;
              /*  beforeboss = false;
                afterboss = false;*/
                now = "middle";
            }
            if ((artificialdistance < bossfightenddistance))
            {
                target.GetComponent<watercolorshifter>().shift = false;
                target.GetComponent<watercolorshifter>().shiftswitch = true;
                if (inboss == true)
                {
                    before = "middle";
                    inboss = false;
                }
              /*  inboss = false;
                beforeboss = false;*/
                beforeboss = false;
                afterboss = true;
                now = "end";
            }
            if (beforeboss == true)
            {
                //parent.transform.position = new Vector3(boat.transform.position.x, 0, boat.transform.position.z);
                Vector3 argh = new Vector3(boat.transform.position.x, 0, boat.transform.position.z);
                parent.transform.position = Vector3.SmoothDamp(parent.transform.position, argh, ref jellyvel, jellyfloat * Time.deltaTime);
                boatstartx = boat.transform.position.x;
            }
            if (beforeboss == false)
            {
                parent.transform.position = new Vector3(boatstartx, 0, boat.transform.position.z);
            }
           
            Vector3 bruh = new Vector3(islanddiamtercheck.position.x, islanddiamtercheck.position.y, islanddiamtercheck.position.z);
            float arghdistance = Vector3.Distance(bruh, parent.transform.position);
            //Debug.Log(arghdistance);
          
            xvelocity = boatrigidbody.velocity.x;
            zvelocity = -boatrigidbody.velocity.z;
         /*   Debug.Log(xvelocity + "bruh");
            Debug.Log(zvelocity);*/
           // sheeshjk.transform.localScale = new Vector3(initialscale, initialscale, initialscale);
           


         /*   if ((scale < endscale + 1) && (scale > endscale - 1))
            {
                keepscaling = false;
            }*/
        /*    if ((scale > -1) && (scale < endscale - 1))
            {
                keepscaling = true;
            }*/
            if ((artificialdistance < cutoff) && (keepscaling == true))
            {
              
          
                keepscaling = false;
                //artificialdistance = cutoff;
            }
           // Debug.Log(keepscaling);

         /*  
            if ((artificialdistance > cutoff - 1) && (artificialdistance < OGad + 1))
            {
                keepscaling = true;
            }*/
                            if (keepscaling == true)
                            {
              //  Debug.Log(artificialdistance);
                              if ((artificialdistance < maxartificialdistance))
                                {
                                    artificialdistance = artificialdistance - zvelocity;
                                }
                                if ((artificialdistance > maxartificialdistance) && (zvelocity > 0))
                                {
                                    artificialdistance = artificialdistance - zvelocity;
                                }

                //artificialdistance = artificialdistance - zvelocity;
                float m = (endscale - initialscale) / (cutoff - OGad);
                                scale = ((m * (artificialdistance - OGad)) + initialscale);
                               
                                sheeshjk.transform.localScale = Vector3.one * Mathf.Clamp(scale, 0, endscale);



                /*
                                float a = Root((endingdowndistance-initialdowndistance+1), (1/(cutoff-OGad)));
                                 float ypos = Mathf.Pow(a, artificialdistance-OGad) + (initialdowndistance -1);
                                sheeshjk.transform.position = new Vector3(sheeshjk.transform.position.x, ypos, sheeshjk.transform.position.z);//GET THIS WORKING*/
                
                                
                             /*   float finaldistance = artificialdistance * scale * thetascale; //  * scale
                                  float addtheta = Mathf.Asin((xvelocity) / (finaldistance));
                                // Debug.Log(addtheta);
                                Quaternion addthetaquaternion = Quaternion.Euler(0, addtheta * Mathf.Rad2Deg, 0);
                                parent.transform.rotation = parent.transform.rotation * addthetaquaternion;
                                sheeshjk.transform.rotation = Quaternion.identity;
*/
                               sheeshjk.transform.parent = parent.transform;
                               realcheck = true;
                            }


                            if (keepscaling == false)
                            {
                                
                                 sheeshjk.transform.parent = null;
                                    isfar = Physics.CheckSphere(sheeshjk.transform.position, distance, boatground);

                                if (isfar == false)
                                {
                                    artificialdistance = cutoff;
                                   // Debug.Log("this part works");
                                    keepscaling = true;
                                }

            //    Debug.Log(diametercutoff);
                if (realcheck == true)
                {
                    diametercutoff = Vector3.Distance(islanddiamtercheck.position, parent.transform.position);
                    realcheck = false;
                }
                float memedistance = Vector3.Distance(islanddiamtercheck.transform.position, boat.transform.position);
           //     Debug.LogError(memedistance);

                float a = Root((endingdowndistance - initialdowndistance + 1), (1 / (memecutoff - diametercutoff)));
                float ypos = Mathf.Pow(a, memedistance - diametercutoff) + (initialdowndistance - 1);
               /* float m = (endingdowndistance-initialdowndistance) / (memecutoff - cutoff);
                float ypos = ((m * (memedistance - cutoff)) + initialdowndistance);*/
                float yposclamp = Mathf.Clamp(ypos, initialdowndistance, endingdowndistance);
                sheeshjk.transform.position = new Vector3(sheeshjk.transform.position.x, yposclamp, sheeshjk.transform.position.z);

                /*     float a = Root((endingdowndistance - initialdowndistance + 1), (1 / (cutoff - OGad)));
                                     float ypos = Mathf.Pow(a, artificialdistance - OGad) + (initialdowndistance - 1);
                                     sheeshjk.transform.position = new Vector3(sheeshjk.transform.position.x, ypos, sheeshjk.transform.position.z);//GET THIS WORKING*/
            }
           


            //thisbit dosent work
                    
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            Die(5f);
        }
     
    }
    public void SpawnIsland()
    {

        FindObjectOfType<AudioManager>().Play("music");
        //Debug.Log("meme");
       keyrotation = Quaternion.Euler(0, 0, 0); //Random.Range(0, 360)
        sheeshjk = Instantiate(islandprefab);
      //  sheeshjk.transform.parent = parent.transform;
        sheeshjk.transform.localScale = Vector3.one * initialscale;
        /*  water = Instantiate(surroundingwaterprefab);
          water.transform.position = new Vector3(0, 1000, - initialdistance);*/
        parent.transform.position = boat.transform.position;
        // sheeshjk.transform.parent = parent;
        sheeshjk.transform.position = new Vector3(parent.transform.position.x, -10.760000228881836f, parent.transform.position.z-distance);
        parent.transform.rotation = keyrotation;
        // sheeshjk.transform.localScale = Vector3.one * initialscale;
        keepscaling = true;
        islandinstantiate = true;
        islanddiamtercheck = sheeshjk.transform.Find("usethis");
        boatstartx = boat.transform.position.x;
       // keepscaling = true;
    }
    float Root(float what, float power)
    {

        if (what < 0.0f)
        {

            return -Mathf.Pow(what, power);
        }

        else
        {

            return Mathf.Pow(what, power);
        }
    }
    public void Die(float deathtime)
    {
        gameoverscreen.SetActive(true);
        if (artificialdistance > bossfightinitialdistance)
        {
            //beginning
            SceneManager.LoadScene(beginning);
        }
        if ((artificialdistance < bossfightinitialdistance) && (artificialdistance > bossfightenddistance))
        {
            //middle
            SceneManager.LoadScene(middle);
        }
        if (artificialdistance < bossfightenddistance)
        {
            //end
            SceneManager.LoadScene(end);
        }
        /* //   ;

            Debug.Log(artificialdistance);
           // hasdied = true;
            //XMLManager.instance.SaveScores(1300);
            // savemanager.GetComponent<>
           // SaveSystem.Save(this);
            Debug.LogAssertion(SaveSystem.Load().hasdied);
           // SceneManager.LoadScene("shehs 2");*/
      /*  
        gameoverscreen.SetActive(true);
        if (player.GetComponent<fpsmovement>().funsyss == true)
        {
            StartCoroutine(truedeathcoroutine(deathtime));
        }
        if (player.GetComponent<fpsmovement>().funsyss == false)
        {
           
            StartCoroutine(falsedeathcoroutine(deathtime));
        }
       */
        //boat.transform.rotation = Quaternion.identity;
       // Debug.Log("dead");
       
        
        //StartCoroutine(deathcoroutine());
        
    }
    public IEnumerator falsedeathcoroutine(float deathtime)
    {
        
        float timer = deathtime;
        yield return new WaitForFixedUpdate();
        player.GetComponent<CharacterController>().enabled = false;
        yield return new WaitForFixedUpdate();
        while (timer > 0)
        {
            timer -= Time.deltaTime;
            Debug.Log(timer);
            yield return new WaitForFixedUpdate();
        }
        player.transform.position = respawnspot.transform.position;
        yield return new WaitForFixedUpdate();
        if (player.transform.position == respawnspot.transform.position)
        {
            player.GetComponent<CharacterController>().enabled = true;
        }
        yield return new WaitForFixedUpdate();
        gameoverscreen.SetActive(false);
        yield return new WaitForFixedUpdate();
    }
    public IEnumerator truedeathcoroutine(float deathtime)
    {
        float timer = deathtime;
        while (timer > 0)
        {
            timer -= Time.deltaTime;
            Debug.Log(timer);
            yield return new WaitForFixedUpdate();
        }
        player.GetComponent<fpsmovement>().getoff = true;
        while (player.GetComponent<fpsmovement>().funsyss == true)
        {
            yield return null;
        }
        gameoverscreen.SetActive(false);
    }

}
