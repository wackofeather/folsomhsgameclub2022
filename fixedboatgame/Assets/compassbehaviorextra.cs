using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class compassbehaviorextra : MonoBehaviour
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
    Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        before = stagedata.GetComponent<islandfollowattempt2>().before;
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
        }
        gameObject.transform.localPosition = Vector3.SmoothDamp(gameObject.transform.localPosition, currentpos, ref velocity, smoothtime * Time.deltaTime);
    }
}
