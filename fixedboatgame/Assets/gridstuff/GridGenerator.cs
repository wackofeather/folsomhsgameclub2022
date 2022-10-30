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
    float oldcount;
    bool oldercount;
    public GameObject flatwater;
    public GameObject plainwater;
    public int plainextend;
    public int flatextend;
    public float flatwaterYoffset;
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
            Debug.Log(initialinstante.transform.position.z);
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
                fart = Instantiate(gridprefab, new Vector3(initialinstante.transform.position.x + xSpace + (xSpace * (i % columnLength)), 0, initialinstante.transform.position.z), Quaternion.identity);
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
                pee = Instantiate(gridprefab, new Vector3(initialinstante.transform.position.x - xSpace - (xSpace * (i % columnLength)), 0, initialinstante.transform.position.z), Quaternion.identity);
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

            Debug.Log(initialinstante.transform.position);
            Debug.Log(Player.transform.position);
           

            //flatwater stage


            

                        for (int j = Mathf.FloorToInt(rowLength / 2); j < Mathf.FloorToInt(rowLength / 2) + flatextend; j++)
                        {
                            GameObject gawdar = Instantiate(flatwater, new Vector3(initialinstante.transform.position.x, flatwaterYoffset, initialinstante.transform.position.z + zSpace + (zSpace * (j))), Quaternion.identity);
                            gawdar.transform.parent = parent.transform;
                            oldtiles.Add(gawdar);
                            for (int i = 0; i < Mathf.Floor(columnLength / 2); i++)
                            {
                                GameObject gawdazk = Instantiate(flatwater, new Vector3(initialinstante.transform.position.x - xSpace - (xSpace * (i)), flatwaterYoffset, initialinstante.transform.position.z + zSpace + (zSpace * (j))), Quaternion.identity);
                                gawdazk.transform.parent = parent.transform;
                                oldtiles.Add(gawdazk);
                            }
                            for (int i = 0; i < Mathf.Floor(columnLength / 2); i++)
                            {
                                GameObject gawdazk = Instantiate(flatwater, new Vector3(initialinstante.transform.position.x + xSpace + (xSpace * (i)), flatwaterYoffset, initialinstante.transform.position.z + zSpace + (zSpace * (j))), Quaternion.identity);
                                gawdazk.transform.parent = parent.transform;
                                oldtiles.Add(gawdazk);
                            }
                        }
                        for (int j = Mathf.FloorToInt(rowLength / 2); j < Mathf.FloorToInt(rowLength / 2) + flatextend; j++)
                        {
                            GameObject gawdak = Instantiate(flatwater, new Vector3(initialinstante.transform.position.x, flatwaterYoffset, initialinstante.transform.position.z - zSpace - (zSpace * (j))), Quaternion.identity);
                            gawdak.transform.parent = parent.transform;
                            oldtiles.Add(gawdak);
                            for (int i = 0; i < Mathf.Floor(columnLength / 2); i++)
                            {
                                GameObject gawdazk = Instantiate(flatwater, new Vector3(initialinstante.transform.position.x - xSpace - (xSpace * (i)), flatwaterYoffset, initialinstante.transform.position.z - zSpace - (zSpace * (j))), Quaternion.identity);
                                gawdazk.transform.parent = parent.transform;
                                oldtiles.Add(gawdazk);
                            }
                            for (int i = 0; i < Mathf.Floor(columnLength / 2); i++)
                            {
                                GameObject gawdazk = Instantiate(flatwater, new Vector3(initialinstante.transform.position.x + xSpace + (xSpace * (i)), flatwaterYoffset, initialinstante.transform.position.z - zSpace - (zSpace * (j))), Quaternion.identity);
                                gawdazk.transform.parent = parent.transform;
                                oldtiles.Add(gawdazk);
                            }
                        }

                        for (int j = Mathf.FloorToInt(columnLength / 2); j < Mathf.FloorToInt(columnLength / 2) + flatextend; j++)
                        {
                            GameObject gawdar = Instantiate(flatwater, new Vector3(initialinstante.transform.position.x + xSpace + (xSpace * (j)), flatwaterYoffset, initialinstante.transform.position.z), Quaternion.identity);
                            gawdar.transform.parent = parent.transform;
                            oldtiles.Add(gawdar);
                            for (int i = 0; i < Mathf.Floor(rowLength / 2) + flatextend; i++)
                            {
                                GameObject gawdazk = Instantiate(flatwater, new Vector3(initialinstante.transform.position.x + xSpace + (xSpace * (j)), flatwaterYoffset, initialinstante.transform.position.z + zSpace + (zSpace * (i))), Quaternion.identity);
                                gawdazk.transform.parent = parent.transform;
                                oldtiles.Add(gawdazk);
                            }
                            for (int i = 0; i < Mathf.Floor(rowLength / 2) + flatextend; i++)
                            {
                                GameObject gawdazk = Instantiate(flatwater, new Vector3(initialinstante.transform.position.x + xSpace + (xSpace * (j)), flatwaterYoffset, initialinstante.transform.position.z - zSpace - (zSpace * (i))), Quaternion.identity);
                                gawdazk.transform.parent = parent.transform;
                                oldtiles.Add(gawdazk);
                            }
                        }
                        for (int j = Mathf.FloorToInt(rowLength / 2); j < Mathf.FloorToInt(rowLength / 2) + flatextend; j++)
                        {
                            GameObject gawdak = Instantiate(flatwater, new Vector3(initialinstante.transform.position.x - xSpace - (xSpace * (j)), flatwaterYoffset, initialinstante.transform.position.z), Quaternion.identity);
                            gawdak.transform.parent = parent.transform;
                            oldtiles.Add(gawdak);
                            for (int i = 0; i < Mathf.Floor(rowLength / 2) + flatextend; i++)
                            {
                                GameObject gawdazk = Instantiate(flatwater, new Vector3(initialinstante.transform.position.x - xSpace - (xSpace * (j)), flatwaterYoffset, initialinstante.transform.position.z + zSpace + (zSpace * (i))), Quaternion.identity);
                                gawdazk.transform.parent = parent.transform;
                                oldtiles.Add(gawdazk);
                            }
                            for (int i = 0; i < Mathf.Floor(rowLength / 2) + flatextend; i++)
                            {
                                GameObject gawdazk = Instantiate(flatwater, new Vector3(initialinstante.transform.position.x - xSpace - (xSpace * (j)), flatwaterYoffset, initialinstante.transform.position.z - zSpace - (zSpace * (i))), Quaternion.identity);
                                gawdazk.transform.parent = parent.transform;
                                oldtiles.Add(gawdazk);
                            }
                        }
            

            //plainwaterstage

            
                           for (int j = Mathf.FloorToInt(rowLength / 2) + flatextend; j < Mathf.FloorToInt(rowLength / 2) + flatextend + plainextend; j++)
                           {
                               GameObject gawdapo = Instantiate(plainwater, new Vector3(initialinstante.transform.position.x, flatwaterYoffset, initialinstante.transform.position.z + zSpace + (zSpace * (j))), Quaternion.identity);
                               gawdapo.transform.parent = parent.transform;
                               oldtiles.Add(gawdapo);
                               for (int i = 0; i < Mathf.Floor(columnLength / 2) + flatextend; i++)
                               {
                                   GameObject gawdazks = Instantiate(plainwater, new Vector3(initialinstante.transform.position.x - xSpace - (xSpace * (i)), flatwaterYoffset, initialinstante.transform.position.z + zSpace + (zSpace * (j))), Quaternion.identity);
                                   gawdazks.transform.parent = parent.transform;
                                   oldtiles.Add(gawdazks);
                               }
                               for (int i = 0; i < Mathf.Floor(columnLength / 2) + flatextend; i++)
                               {
                                   GameObject gawdazka = Instantiate(plainwater, new Vector3(initialinstante.transform.position.x + xSpace + (xSpace * (i)), flatwaterYoffset, initialinstante.transform.position.z + zSpace + (zSpace * (j))), Quaternion.identity);
                                   gawdazka.transform.parent = parent.transform;
                                   oldtiles.Add(gawdazka);
                               }
                           }
                           for (int j = Mathf.FloorToInt(rowLength / 2) + flatextend; j < Mathf.FloorToInt(rowLength / 2) + flatextend + plainextend; j++)
                           {
                               GameObject gawdakz = Instantiate(plainwater, new Vector3(initialinstante.transform.position.x, flatwaterYoffset, initialinstante.transform.position.z - zSpace - (zSpace * (j))), Quaternion.identity);
                               gawdakz.transform.parent = parent.transform;
                               oldtiles.Add(gawdakz);
                               for (int i = 0; i < Mathf.Floor(columnLength / 2) + flatextend; i++)
                               {
                                   GameObject gawdazkop = Instantiate(plainwater, new Vector3(initialinstante.transform.position.x - xSpace - (xSpace * (i)), flatwaterYoffset, initialinstante.transform.position.z - zSpace - (zSpace * (j))), Quaternion.identity);
                                   gawdazkop.transform.parent = parent.transform;
                                   oldtiles.Add(gawdazkop);
                               }
                               for (int i = 0; i < Mathf.Floor(columnLength / 2) + flatextend; i++)
                               {
                                   GameObject gawdazkes = Instantiate(plainwater, new Vector3(initialinstante.transform.position.x + xSpace + (xSpace * (i)), flatwaterYoffset, initialinstante.transform.position.z - zSpace - (zSpace * (j))), Quaternion.identity);
                                   gawdazkes.transform.parent = parent.transform;
                                   oldtiles.Add(gawdazkes);
                               }
                           }

                           for (int j = Mathf.FloorToInt(columnLength / 2) + flatextend; j < Mathf.FloorToInt(columnLength / 2) + flatextend + plainextend; j++)
                           {
                               GameObject gawdaresa = Instantiate(plainwater, new Vector3(initialinstante.transform.position.x + xSpace + (xSpace * (j)), flatwaterYoffset, initialinstante.transform.position.z), Quaternion.identity);
                               gawdaresa.transform.parent = parent.transform;
                               oldtiles.Add(gawdaresa);
                               for (int i = 0; i < Mathf.Floor(rowLength / 2) + flatextend + plainextend; i++)
                               {
                                   GameObject gawdazkeesa = Instantiate(plainwater, new Vector3(initialinstante.transform.position.x + xSpace + (xSpace * (j)), flatwaterYoffset, initialinstante.transform.position.z + zSpace + (zSpace * (i))), Quaternion.identity);
                                   gawdazkeesa.transform.parent = parent.transform;
                                   oldtiles.Add(gawdazkeesa);
                               }
                               for (int i = 0; i < Mathf.Floor(rowLength / 2) + flatextend + plainextend; i++)
                               {
                                   GameObject gawdazkase = Instantiate(plainwater, new Vector3(initialinstante.transform.position.x + xSpace + (xSpace * (j)), flatwaterYoffset, initialinstante.transform.position.z - zSpace - (zSpace * (i))), Quaternion.identity);
                                   gawdazkase.transform.parent = parent.transform;
                                   oldtiles.Add(gawdazkase);
                               }
                           }
                           for (int j = Mathf.FloorToInt(rowLength / 2) + flatextend; j < Mathf.FloorToInt(rowLength / 2) + flatextend + plainextend; j++)
                           {
                               GameObject gawdakose = Instantiate(plainwater, new Vector3(initialinstante.transform.position.x - xSpace - (xSpace * (j)), flatwaterYoffset, initialinstante.transform.position.z), Quaternion.identity);
                               gawdakose.transform.parent = parent.transform;
                               oldtiles.Add(gawdakose);
                               for (int i = 0; i < Mathf.Floor(rowLength / 2) + flatextend + plainextend; i++)
                               {
                                   GameObject gawdazkosep = Instantiate(plainwater, new Vector3(initialinstante.transform.position.x - xSpace - (xSpace * (j)), flatwaterYoffset, initialinstante.transform.position.z + zSpace + (zSpace * (i))), Quaternion.identity);
                                   gawdazkosep.transform.parent = parent.transform;
                                   oldtiles.Add(gawdazkosep);
                               }
                               for (int i = 0; i < Mathf.Floor(rowLength / 2) + flatextend + plainextend; i++)
                               {
                                   GameObject gawdazkgigi = Instantiate(plainwater, new Vector3(initialinstante.transform.position.x - xSpace - (xSpace * (j)), flatwaterYoffset, initialinstante.transform.position.z - zSpace - (zSpace * (i))), Quaternion.identity);
                                   gawdazkgigi.transform.parent = parent.transform;
                                   oldtiles.Add(gawdazkgigi);
                               }
                           }

            



            /*
                        for (int i = Mathf.FloorToInt(columnLength / 2); i < Mathf.Floor(columnLength / 2) + flatextend; i++)
                        {
                            fart = Instantiate(gridprefab, new Vector3(initialinstante.transform.position.x + xSpace + (xSpace * (i % columnLength)), 0, initialinstante.transform.position.z), Quaternion.identity);
                            for (int j = 0; j < Mathf.Floor(rowLength / 2) + flatextend; j++)
                            {
                                GameObject shsh = Instantiate(flatwater, new Vector3(fart.transform.position.x, 0, fart.transform.position.z + zSpace + (zSpace * (j % rowLength))), Quaternion.identity);
                                shsh.transform.parent = parent.transform;
                                oldtiles.Add(shsh);
                            }
                            for (int j = 0; j < Mathf.Floor(rowLength / 2) + flatextend; j++)
                            {
                                GameObject sh = Instantiate(flatwater, new Vector3(fart.transform.position.x, 0, fart.transform.position.z - zSpace - (zSpace * (j % rowLength))), Quaternion.identity);
                                sh.transform.parent = parent.transform;
                                oldtiles.Add(sh);
                            }
                            fart.transform.parent = parent.transform;
                            oldtiles.Add(fart);
                        }
            */



            /* for (int i = 0; i < oldtiles.Count; i++)
             {
                 oldtiles[i].name = i.ToString();
             }*/
            gridinstantiate = false;
        }

       /* if (Input.GetKeyDown(KeyCode.E))
        {

            Debug.Log("work");
            
           
            for (int i = 0; i < oldtiles.Count; i++)
            {
                if (oldtiles[i] != null)
                {
                    
                    Destroy(oldtiles[i]);
                    //oldtiles.Remove(oldtiles[i]);
                }
              
            }
            gridinstantiate = true;
        }*/
        /*if (oldtiles.Count == 0)
        {
            gridinstantiate = true;
            oldercount = true;
            Debug.Log("bruh");
        }*/
        
      
    }
}
