using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitout : MonoBehaviour
{
    public Animator animations;
    public float animationseconds;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if ((timer > animationseconds))
        {
            Application.Quit();
         //   Debug.Log("quit");
        }
    }
}
