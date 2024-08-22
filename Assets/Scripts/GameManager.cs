using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int maxScore; //Max score
    public string maxScoreName;  //Name of the player with the highest score
    public string playerName; //Current players name
    

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [System.Serializable]
    class SaveData
    {
        public string maxScoreName;
        public int maxScore;
    }

    public void SaveScore()
    {
        SaveData data = new SaveData();

        data.maxScore = maxScore;
        data.maxScoreName = maxScoreName;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";

        if(File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            maxScoreName = data.maxScoreName;
            maxScore = data.maxScore;
        }
    }
}
