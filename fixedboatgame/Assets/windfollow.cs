using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windfollow : MonoBehaviour
{
    public GameObject ship;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ship.transform.position;
    }
}
