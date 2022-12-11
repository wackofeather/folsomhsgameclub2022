using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simmer : MonoBehaviour
{
    public GameObject player;
    public GameObject watersim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool onisland = player.GetComponent<isonisland>().onisland;
        if (onisland)
        {
            watersim.SetActive(true);
        }
        if (!onisland)
        {
            watersim.SetActive(false);
        }
    }
}
