using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    public int columnLength;
    public int rowLength;

    public float xSpace;
    public float zSpace;
    public bool gridinstantiate;
    public GameObject gridprefab;
    // Start is called before the first frame update
    void Start()
    {
        gridinstantiate = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (gridinstantiate == true)
        {
            for (int i=0; i<columnLength * rowLength; i++)
            {
                Instantiate(gridprefab, new Vector3(xSpace + (xSpace * (i % columnLength)), 0, zSpace + (zSpace * (i / columnLength))), Quaternion.identity);
            }
            gridinstantiate = false;
        }
      
    }
}
