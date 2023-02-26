using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windtest2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject distanceislander;
    bool inboss;
    bool beforeboss;
    bool afterboss;
    bool isgoingback;
    bool initialize1;
    bool initialize2;
    bool initialize3;
    public float bossshifttime;
    public float aftershiftime;
    public float initialbosstime;
    public float initialaftertime;
    void Start()
    {
        windshift();
        isgoingback = false;
        initialize1 = true;
        initialize2 = true;
        initialize3 = true;
        // transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        // InvokeRepeating("windshift", 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        inboss = distanceislander.GetComponent<islandfollowmiddle>().inboss;
        beforeboss = distanceislander.GetComponent<islandfollowmiddle>().beforeboss;
        afterboss = distanceislander.GetComponent<islandfollowmiddle>().afterboss;

        if (beforeboss)
        {
            if (initialize1)
            {
                // Debug.Log("before");
                if (isgoingback)
                {
                    if (IsInvoking("windshift"))
                    {
                        CancelInvoke("windshift");
                    }
                    if (!IsInvoking("windshift"))
                    {
                        InvokeRepeating("windshift", initialaftertime, aftershiftime);
                    }
                }
                if (!isgoingback)
                {
                    //windshift();

                }
                initialize2 = true;
                initialize3 = true;
                initialize1 = false;
            }

        }
        if (inboss)
        {
            if (initialize2)
            {

                isgoingback = true;
                Debug.Log("middle");
                if (IsInvoking("windshift"))
                {
                    CancelInvoke("windshift");
                }
                if (!IsInvoking("windshift"))
                {
                    InvokeRepeating("windshift", initialbosstime, bossshifttime);
                }
                initialize1 = true;
                initialize3 = true;
                initialize2 = false;
            }
        }
        if (afterboss)
        {
            if (initialize3)
            {


                Debug.Log("after");
                isgoingback = true;
                if (IsInvoking("windshift"))
                {
                    CancelInvoke("windshift");
                }
                if (!IsInvoking("windshift"))
                {
                    InvokeRepeating("windshift", initialaftertime, aftershiftime);
                }
                initialize1 = true;
                initialize2 = true;
                initialize3 = false;
            }
        }
        /*     if (Input.GetKeyDown(KeyCode.Alpha8))
             {
                 windshift();
             }*/
    }
    public void windshift()
    {
        float randangle = Random.Range(0, 360);
        transform.rotation = Quaternion.Euler(new Vector3(0, randangle, 0));
    }
}
