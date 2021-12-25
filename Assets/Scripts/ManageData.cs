using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public static class ManageData
{
    class Data
    {
        public string name;
        public int score;
    }

    public static void SaveData()
    {
        Data data = new Data();
        data.name = GameManager.gameManager.bestPlayer;
        data.score = GameManager.gameManager.highestScore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public static void LoadData()
    {
        string path = Application.persistentDataPath + "/savefile.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            Data data = JsonUtility.FromJson<Data>(json);

            GameManager.gameManager.bestPlayer = data.name;
            GameManager.gameManager.highestScore = data.score;
        }
    }

    public static void ClearData()
    {
        GameManager.gameManager.bestPlayer = "";
        GameManager.gameManager.highestScore = 0;
        SaveData();
    }
}
