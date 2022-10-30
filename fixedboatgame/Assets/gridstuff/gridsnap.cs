using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridsnap : MonoBehaviour
{
    public GameObject asset;
    public GameObject target;
    Vector3 truePos;
    Vector3 plaerpos;
    public float gridsize;
    public GameObject player;
    public bool sheshsk;
    public GameObject genertorer;
    void Start()
    {
        sheshsk = true;
    }
    void LateUpdate()
    {
        if (sheshsk == true)
        {
            plaerpos = player.transform.position;
            sheshsk = false;
        }
        target = gameObject;
        asset = gameObject;
        truePos.x = Mathf.Floor((target.transform.position.x - plaerpos.x)/gridsize) * gridsize;
       truePos.y = Mathf.Floor(target.transform.position.y / gridsize) * gridsize;
        truePos.z = Mathf.Floor((target.transform.position.z - plaerpos.z)/gridsize) * gridsize;
        //Debug.Log(truePos.x);
        asset.transform.position = truePos;
        
      
    }
}
