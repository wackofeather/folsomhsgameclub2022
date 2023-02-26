using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class distancedata
{
    public float distance;
    public bool island;
    public bool hasdied;
    
    public distancedata (islandfollowattempt2 parent)
    {
        distance = parent.artificialdistance;
        island = parent.islandinstantiate;
        hasdied = parent.hasdied;
    }

}
