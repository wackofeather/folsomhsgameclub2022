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
    public Transform Player;
    public GameObject parent;
    GameObject fart;
    GameObject pee;
    // Start is called before the first frame update
    public List<GameObject> oldtiles = new List<GameObject>();
    void Start()
    {
        gridinstantiate = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (gridinstantiate == true)
        {
            
            GameObject initialinstante = Instantiate(gridprefab, new Vector3(Player.position.x, 0, Player.position.z), Quaternion.identity);
            oldtiles.Add(initialinstante);
            for (int j = 0; j < Mathf.Floor(rowLength / 2); j++)
            {
                GameObject gawdam = Instantiate(gridprefab, new Vector3(initialinstante.transform.position.x, 0, initialinstante.transform.position.z + zSpace + (zSpace * (j % rowLength))), Quaternion.identity);
                gawdam.transform.parent = parent.transform;
                oldtiles.Add(gawdam);
            }
            for (int j = 0; j < Mathf.Floor(rowLength / 2); j++)
            {
                GameObject gawda = Instantiate(gridprefab, new Vector3(initialinstante.transform.position.x, 0, initialinstante.transform.position.z - zSpace - (zSpace * (j % rowLength))), Quaternion.identity);
                gawda.transform.parent = parent.transform;
                oldtiles.Add(gawda);
            }
            initialinstante.transform.parent = parent.transform;
            for (int i=0; i<Mathf.Floor(columnLength/2); i++)
            {
                fart = Instantiate(gridprefab, new Vector3(initialinstante.transform.position.x + xSpace + (xSpace * (i % columnLength)), 0, 0), Quaternion.identity);
                for (int j = 0; j < Mathf.Floor(rowLength / 2); j++)
                {
                    GameObject shsh = Instantiate(gridprefab, new Vector3(fart.transform.position.x, 0, fart.transform.position.z + zSpace + (zSpace * (j % rowLength))), Quaternion.identity);
                    shsh.transform.parent = parent.transform;
                    oldtiles.Add(shsh);
                }
                for (int j = 0; j < Mathf.Floor(rowLength / 2); j++)
                {
                    GameObject sh = Instantiate(gridprefab, new Vector3(fart.transform.position.x, 0, fart.transform.position.z - zSpace - (zSpace * (j % rowLength))), Quaternion.identity);
                    sh.transform.parent = parent.transform;
                    oldtiles.Add(sh);
                }
                fart.transform.parent = parent.transform;
                oldtiles.Add(fart);
            }
            for (int i = 0; i < Mathf.Floor(columnLength / 2); i++)
            {
                pee = Instantiate(gridprefab, new Vector3(initialinstante.transform.position.x - xSpace - (xSpace * (i % columnLength)), 0, 0), Quaternion.identity);
                for (int j = 0; j < Mathf.Floor(rowLength / 2); j++)
                {
                    GameObject huhuh = Instantiate(gridprefab, new Vector3(pee.transform.position.x, 0, pee.transform.position.z - zSpace - (zSpace * (j % rowLength))), Quaternion.identity);
                    huhuh.transform.parent = parent.transform;
                    oldtiles.Add(huhuh);
                }
                for (int j = 0; j < Mathf.Floor(rowLength / 2); j++)
                {
                    GameObject dududn = Instantiate(gridprefab, new Vector3(pee.transform.position.x, 0, pee.transform.position.z + zSpace + (zSpace * (j % rowLength))), Quaternion.identity);
                    dududn.transform.parent = parent.transform;
                    oldtiles.Add(dududn);
                }
                pee.transform.parent = parent.transform;
                oldtiles.Add(pee);
            }
            for (int i = 0; i < oldtiles.Count; i++)
            {
                oldtiles[i].name = i.ToString();
            }
                gridinstantiate = false;
        }



      
    }
}
