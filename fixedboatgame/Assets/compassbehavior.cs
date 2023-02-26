using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class compassbehavior : MonoBehaviour
{
    public GameObject stagedata;
    string before;
    string now;
    public Vector3 downpos;
    Vector3 currentpos;
    float smoothtime;
    public float regulartime;
    public float middletime;
    public float quicktime;
    float Yvelocity;
    Vector3 OGpos;
    float posX;
    float posZ;
    public float shakeFrequency;
    bool shake;
    public ParticleSystem particles;
    // Start is called before the first frame update
    void Start()
    {
        OGpos = new Vector3(gameObject.transform.localPosition.x, 0, gameObject.transform.localPosition.z);
        currentpos = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
      /*  before = stagedata.GetComponent<islandfollowattempt2>().before;
        now = stagedata.GetComponent<islandfollowattempt2>().now;
        if ((before == "null") && (now == "beginning"))
        {
            currentpos = Vector3.zero;
            smoothtime = regulartime;
        }
        if ((before == "beginning") && (now == "middle"))
        {
            currentpos = Vector3.zero;
            smoothtime = middletime;
        }
        if ((before == "middle") && (now == "end"))
        {
            currentpos = downpos;
            smoothtime = quicktime;
        }
        if ((before == "end") && (now == "middle"))
        {
            currentpos = downpos;
            smoothtime = quicktime;
        }
        if ((before == "middle") && (now == "beginning"))
        {
            currentpos = downpos;
            smoothtime = quicktime;
        }
        if ((before == "null") && (now == "middle"))
        {
            currentpos = downpos;
            smoothtime = quicktime;
        }
        if ((before == "null") && (now == "end"))
        {
            currentpos = downpos;
            smoothtime = quicktime;
        }*/
        //Debug.Log(Vector3.Distance(gameObject.transform.localPosition, currentpos));
  /*      if (Vector3.Distance(gameObject.transform.localPosition, currentpos) > 0.01)
        {
            Debug.Log("shake");
            posX = OGpos.x + Random.insideUnitCircle.x * shakeFrequency;
            posZ = OGpos.z + Random.insideUnitCircle.y * shakeFrequency;
            particles.enableEmission = true;
        }
        if (Vector3.Distance(gameObject.transform.localPosition, currentpos) < 0.01)
        {
            *//*  Debug.Log("shake");
              posX = OGpos.x + Random.insideUnitCircle.x * shakeFrequency;
              posZ = OGpos.z + Random.insideUnitCircle.y * shakeFrequency;*//*
            particles.enableEmission = false;
        }*/

        gameObject.transform.localPosition = new Vector3(posX, Mathf.SmoothDamp(gameObject.transform.localPosition.y, currentpos.y, ref Yvelocity, smoothtime * Time.deltaTime), posZ);
    }
}
