using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
   public static void Save(islandfollowattempt2 parent)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.fun";
        FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
        if (File.Exists(path))
        {
            distancedata data = new distancedata(parent);
            formatter.Serialize(stream, data);
            stream.Close();
        }
        else
        {
            Debug.Log("save file not found in" + path);
            stream.Close();
            //return null;
        }

    }

    public static distancedata Load()
    {
        string path = Application.persistentDataPath + "/player.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            distancedata data = formatter.Deserialize(stream) as distancedata;
            stream.Close();
            return data;

        }
        else
        {
            Debug.Log("save file not found in" + path);
            return null;
        }
    }
}
