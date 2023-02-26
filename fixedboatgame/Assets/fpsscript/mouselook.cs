using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselook : MonoBehaviour
{
  //  public GameObject canmoveobject;

    public float sens = 100f;

    public Transform playerbody;

    float xrotation = 0;
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
       
       
            float mouseX = Input.GetAxis("Mouse X") * sens * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * sens * Time.deltaTime;
            xrotation -= mouseY;
            xrotation = Mathf.Clamp(xrotation, -90f, 90f);
            transform.localRotation = Quaternion.Euler(xrotation, 0, 0);
            playerbody.Rotate(Vector3.up * mouseX);
        
    
    }
}
