using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endtrigger : MonoBehaviour
{
    public bool ending;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        player.GetComponent<endingfpsmovement>().canmove = false;
        ending = true;
    }
}
