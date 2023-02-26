using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselookend : MonoBehaviour
{
    public GameObject canmoveobject;

    public float sens = 100f;

    public Transform playerbody;

    float xrotation = 0;

    public GameObject parent;
    public GameObject endtrigger;
    public bool shockanim;
    public Animator animationcontroller;
    public float rotationdelta;
    float timer;
    public bool fadeout;
    bool switchs;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetFloat("sensitivity") != 0f)
        {
            sens = PlayerPrefs.GetFloat("sensitivity");
        }
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        bool canmove = canmoveobject.GetComponent<endingfpsmovement>().canmove;
        if (canmove)
        {
            transform.parent = parent.transform;
            float mouseX = Input.GetAxis("Mouse X") * sens * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * sens * Time.deltaTime;
            xrotation -= mouseY;
            xrotation = Mathf.Clamp(xrotation, -90f, 90f);
            transform.localRotation = Quaternion.Euler(xrotation, 0, 0);
            playerbody.Rotate(Vector3.up * mouseX);
            shockanim = false;
            fadeout = false;
            timer = 0;
            switchs = false;
        }
        bool ending = endtrigger.GetComponent<endtrigger>().ending;
        bool cameraunlock = parent.GetComponent<endingfpsmovement>().cameraunlock;
        if (!canmove && ending && cameraunlock)
        {
          
            if (Mathf.DeltaAngle(gameObject.transform.localEulerAngles.x, 0) < 0.1)
            {
                transform.parent = null;
                shockanim = true;
                animationcontroller.SetBool("shockanim", shockanim);
                if (switchs == false)
                {
                    FindObjectOfType<AudioManager>().InstancePlay("clack");
                    switchs = true;
                }
                timer += Time.deltaTime;
                if (timer > 3f)
                {
                    //Debug.Log("over");
                    fadeout = true;
                }
            }
          
        }

    }
}
