using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridsnap : MonoBehaviour
{
    public GameObject asset;
    public GameObject target;
    Vector3 truePos;
    public float gridsize;
    void LateUpdate()
    {
        target = gameObject;
        asset = gameObject;
        truePos.x = Mathf.Floor(target.transform.position.x/gridsize) * gridsize;
        truePos.y = Mathf.Floor(target.transform.position.y / gridsize) * gridsize;
        truePos.z = Mathf.Floor(target.transform.position.z/gridsize) * gridsize;
        //Debug.Log(truePos.x);
        asset.transform.position = truePos;
    }
}
