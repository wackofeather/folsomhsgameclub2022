using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridfollowtest : MonoBehaviour
{

    public GameObject grid;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            player = GameObject.Find("sidfpscontoller");
        }
        /*Vector3 gridposx = new Vector3(grid.transform.position.x, 0 , 0);
        gridposx = new Vector3(player.transform.position.x, 0, 0);
        Vector3 gridposz = new Vector3(0, 0 , grid.transform.position.z);
        gridposx = new Vector3(0, 0, player.transform.position.z);*/

        if (player != null)
        {
            transform.position = new Vector3(player.transform.position.x, 0, player.transform.position.z);
        }

       


    }
}
