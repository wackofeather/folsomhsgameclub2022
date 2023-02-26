using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;
using UnityEngine.ParticleSystemJobs;
public class spawnprojectors : MonoBehaviour
{
    public GameObject projecotrprefab;
    public float offsetY;
    public GameObject bossfightchecker;
    public GameObject asteroidprefab;
    public GameObject meteorstart;
    public float projectiletime;
    float mingravity;
    float maxgravity;
    public float projectileheight;
    public float uptime;
    public float maxvelocity;
    public float speedup;
    public float downtime;
    public AnimationCurve asteroideasetype;
    public AnimationCurve asteroideasetype2;
    public Ease asteroideasetype3;
    public float delay;
    public float fadeoutshiftspeed;
    public Material decalmaterial;
    public Material alphamaterial;
    bool firstspawn;
    bool invokeinitialize;
    TweenParams tParms;
    public float timebetweenasteroids;
    public GameObject boat;
    public float boatdeathradius;
    public LayerMask boatlayermask;
    public GameObject gameoverscreen;
    public camerashake shakescript;
    public GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        invokeinitialize = true;
        tParms = new TweenParams().SetEase(asteroideasetype2).SetDelay(delay);
        firstspawn = true;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            FindObjectOfType<AudioManager>().Play("asteroid");
        }
        if (parent == null)
        {
            parent = GameObject.Find("islandParent");
        }
        bool bossfight = bossfightchecker.GetComponent<watercolorshifter>().bossfight;
        if ((bossfight) && (invokeinitialize))
        {
            InvokeRepeating("spawnprojector", 1f, timebetweenasteroids);
            invokeinitialize = false;
        }
      /*  if (Input.GetKeyDown(KeyCode.Z))
        {
            spawnprojector();
        }*/
    }

    void spawnprojector()
    {
       
        
        bool bossfight = bossfightchecker.GetComponent<watercolorshifter>().bossfight;
        if (bossfight)
        {
            if (firstspawn == true)
            {
                meteorstart = GameObject.Find("meteorspawner");
                firstspawn = false;
            }
           
           // Debug.Log("done");
            Bounds bounds = GetComponent<Collider>().bounds;
            float offsetX = Random.Range(-bounds.extents.x, bounds.extents.x);

            float offsetZ = Random.Range(-bounds.extents.z, bounds.extents.z);
      
            GameObject newHazard = Instantiate(projecotrprefab);
        Transform target = newHazard.transform.GetChild(0);
       // Debug.Log(target.name);
      //  meteorstart.transform.position = new Vector3(meteorstart.transform.position.x,newHazard.transform.position.y, meteorstart.transform.position.z);
            newHazard.transform.position = bounds.center + new Vector3(offsetX, offsetY, offsetZ);
        StartCoroutine(throwmeteor(target, newHazard, projectiletime));
       }
       
    }
    
    IEnumerator throwmeteor(Transform target, GameObject decal,float time)
    {
      //  Vector3[] waypoints = new Vector3[3];
        
       // Debug.Log(time);
        GameObject asteroid = Instantiate(asteroidprefab);
        asteroid.transform.position = meteorstart.transform.position;
        /*   float targetx = asteroid.transform.position.x;
           float targety = asteroid.transform.position.y;
           float targetz = asteroid.transform.position.z;
           Vector3 targetvector = new Vector3(targetx, targety, targetz);*/
/*        Vector3 velocity = Vector3.zero;
        float xvelocity = 0;
        float yvelocity = 0;
        //float clampdyvelocity = Mathf.Clamp(yvelocity, minvelocity, 10000);
        float zvelocity = 0;
        float theta = 360 - meteorstart.transform.eulerAngles.x;
        float gravity = Random.Range(mingravity, maxgravity);
        float endingy = target.position.y;
        float endingx = target.position.x;
        float emdingz = target.position.z;
        float startingx = meteorstart.transform.position.x;
        float startingy = meteorstart.transform.position.y;
        float startingz = meteorstart.transform.position.z;
        float halfway = Mathf.Abs(((startingx + endingx) / 2));
        bool startdown = false;
        *//*       float a = -projectileheight / (((startingx - endingx) / 2) * ((startingx - endingx) / 2));
               float b = (endingx + startingx) / 2;*//*
        float f = Mathf.Pow(((startingx - endingx) / 2), 2) - Mathf.Pow(((endingx - startingx) / 2), 2);
        float a = startingy / f;
        float b = (endingx + startingx) / 2;
        asteroid.transform.position =  meteorstart.transform.position;
        Vector3 targetvector = meteorstart.transform.position;
        float ycomp = meteorstart.transform.position.y;
        Quaternion lookat = Quaternion.LookRotation(meteorstart.transform.position - decal.transform.position, Vector3.up);
        float g = (2 * startingy - 2 * projectileheight) / (startingx - endingx);
        float k = (2 * projectileheight - 2 * endingy) / (startingx - endingx);
        Vector3 downtargrt = new Vector3(target.position.x, target.position.y - 30, target.position.z);
      //  waypoints[0] = meteorstart.transform.position;
        waypoints[0] = new Vector3((endingx + startingx) / 2, projectileheight, (emdingz + startingz) / 2);
        waypoints[1] = new Vector3(decal.transform.position.x, decal.transform.position.y, decal.transform.position.z);
        waypoints[2] = new Vector3(target.transform.position.x, target.transform.position.y - 30, target.transform.position.z);*/
        
        // asteroid.transform.DOPath(waypoints, time, PathType.CatmullRom).SetAs(tParms);
        asteroid.transform.DOJump(target.transform.position, projectileheight, 1, time, false).SetAs(tParms);
        while (Vector3.Distance(asteroid.transform.position, target.transform.position) > 0.1)
        {
            //  Rigidbody asteroidrb = asteroid.GetComponent<Rigidbody>();

                // decal.transform.rotation = Quaternion.Euler(90, lookat.eulerAngles.y, 0);

                /*  float xcomp = Mathf.SmoothDamp(asteroid.transform.position.x, target.position.x, ref xvelocity, time * Time.deltaTime);
                  //float ycomp = Mathf.SmoothDamp(asteroid.transform.position.y, target.transform.position.y, ref yvelocity, time * Time.deltaTime);
                  *//*  float force = (endingy - startingy - ((gravity / 2) * time * time)) / (time * Mathf.Sin(theta * Mathf.Deg2Rad));
                    float distancetotime = ((endingx) / (force * Mathf.Cos(theta * Mathf.Deg2Rad))) - (((xcomp) / (force * Mathf.Cos(theta * Mathf.Deg2Rad))));
                    float ycomp = (gravity / 2) * (distancetotime) * (distancetotime) + force * Mathf.Sin(theta * Mathf.Deg2Rad) * (distancetotime) + startingy;
                  *//*

                  if (Mathf.Abs(xcomp) < halfway)
                  {
                      // Debug.Log("before");
                      ///  ycomp = Mathf.SmoothDamp(asteroid.transform.position.y, projectileheight, ref yvelocity, (time/4) * Time.deltaTime);
                      ycomp = g * (xcomp - startingx) + startingy;
                  }
                  if ((Mathf.Abs(xcomp) > halfway))
                  {
                      time -= speedup;
                      //  Debug.Log("after");
                      /// ycomp = Mathf.SmoothDamp(asteroid.transform.position.y, target.position.y, ref yvelocity, (3 * time / 4) * Time.deltaTime);
                      ycomp = k * (xcomp - endingx) + endingy;
                      if (Vector3.Distance(asteroid.transform.position, target.transform.position) < 0.1)
                      {
                          Debug.Log("thisworks");
                          startdown = true;
                          //comp = Mathf.SmoothDamp(asteroid.transform.position.y, target.position.y-30, ref yvelocity, (3 * time / 4) * Time.deltaTime);
                      }
                      if (startdown == true)
                      {
                          ycomp = Mathf.SmoothDamp(asteroid.transform.position.y, downtargrt.y, ref yvelocity, (3 * time / 4) * Time.deltaTime);
                      }
                  }

                      float zcomp = Mathf.SmoothDamp(asteroid.transform.position.z, target.position.z, ref zvelocity, time * Time.deltaTime);
                  //asteroid.transform.position = Vector3.SmoothDamp(asteroid.transform.position, target.transform.position, ref velocity, time * Time.deltaTime);
                  asteroid.transform.position = new Vector3(xcomp, ycomp, zcomp);
                  if (Vector3.Distance(asteroid.transform.position, downtargrt) < 0.1)
                  {
                      Debug.Log("stopped");
                     // Destroy(decal);
                     // Destroy(asteroid);
                      StopCoroutine("throwmeteor");
                  }*/

                yield return null;
        }
        //Debug.Log("going down");
        FindObjectOfType<AudioManager>().InstancePlay("asteroid");
        shakescript.StartShake();

        if (Physics.CheckSphere(decal.transform.position, boatdeathradius, boatlayermask))
        {
          parent.GetComponent<islandfollowattempt2>().Die(30f);
        }
        asteroid.transform.DOMoveY(target.transform.position.y - 30, downtime);
        Material material = decal.GetComponent<DecalProjector>().material;
      //  Debug.Log(material.name);
        StartCoroutine(Fadeouttarget(decal, material, asteroid));
       
        yield return null;
    }
    IEnumerator Fadeouttarget(GameObject projector, Material decal, GameObject asteroid)
    {
        ParticleSystem splash = projector.GetComponentInChildren<ParticleSystem>();
        splash.Play();
        float velocity = 0;
        DecalProjector trys = projector.GetComponent<DecalProjector>();
      //  Debug.Log("teheheheheheheh");
        while (trys.fadeFactor > 0.01f)
        {
            trys.fadeFactor *= fadeoutshiftspeed;
            yield return new WaitForFixedUpdate();
        }
        //Color ogcolor = decal.color;
        // Color fadedoutcolor = new Color(decal.color.r, decal.color.g, decal.color.b, 0);
        /*   while (trys != alphamaterial)
           {
               trys.Lerp(decal, alphamaterial, fadeoutshiftspeed * Time.deltaTime);
               yield return null;
           }*/
    
       
        GameObject.Destroy(projector);
        GameObject.Destroy(asteroid);
        yield return new WaitForFixedUpdate();
    }
    //DOSEN"T WORK
}
