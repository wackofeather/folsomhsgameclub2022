using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sailuifollow : MonoBehaviour
{
    public GameObject sail;
    public float smoothfollow;
    float velocity;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frames
    void Update()
    {
        float smoothrote = Mathf.SmoothDampAngle(gameObject.transform.localEulerAngles.z, sail.transform.localEulerAngles.y, ref velocity, smoothfollow * Time.deltaTime);
        Quaternion sailrotation = Quaternion.Euler(0, 0, smoothrote);
     //   Debug.Log(boat.transform.localEulerAngles.y);
        gameObject.transform.localRotation = sailrotation;
    }
}
