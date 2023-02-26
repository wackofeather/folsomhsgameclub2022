using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System.IO;
public class XMLManager : MonoBehaviour
{
    public static XMLManager instance;
    public Leaderboard leaderboard;
    private static GameObject sampleInstance;
    void Awake()
    {
        instance = this;
        if (!Directory.Exists(Application.persistentDataPath + "/HighScores/"))
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/HighScores/");
        }
      
    }
    public void SaveScores(float distances)
    {
        leaderboard.distancesaved = distances;
       // leaderboard.islandon = islandons;
        XmlSerializer serializer = new XmlSerializer(typeof(Leaderboard));
        FileStream stream = new FileStream(Application.persistentDataPath + "/HighScores/highscores.xml", FileMode.Create);
        serializer.Serialize(stream, leaderboard);
        stream.Close();
    }
    public Leaderboard LoadScores()
    {
        if (File.Exists(Application.persistentDataPath + "/HighScores/highscores.xml"))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Leaderboard));
            FileStream stream = new FileStream(Application.persistentDataPath + "/HighScores/highscores.xml", FileMode.Open);
            leaderboard = serializer.Deserialize(stream) as Leaderboard;
        }
        return leaderboard;
        
    }
 

}
[System.Serializable]
public class Leaderboard
{
    public float distancesaved;
   // public bool islandon;
}