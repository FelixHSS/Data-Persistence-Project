using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Linq;

public static class ManageData
{
    [Serializable]
    class Data
    {
        //public string name;
        //public int score;

        public List<PlayerRecord> records;

        public Data()
        {
            records = new List<PlayerRecord>();
        }

        public Data(List<PlayerRecord> records)
        {
            this.records = new List<PlayerRecord>(records);

            //for (int i = 0; i < records.Count; i++)
            //{
            //    this.records.Add(records[i]);
            //}
        }
    }

    public static void SaveData()
    {
        Data data = new Data(GameManager.gameManager.records);
        //data.name = GameManager.gameManager.bestPlayer;
        //data.score = GameManager.gameManager.highestScore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json2", json);
    }

    public static void LoadData()
    {
        Debug.Log(Application.persistentDataPath);

        string path = Application.persistentDataPath + "/savefile.json2";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            Data data = JsonUtility.FromJson<Data>(json);

            //GameManager.gameManager.bestPlayer = data.name;
            //GameManager.gameManager.highestScore = data.score;
            if (data.records.Any())
            {
                GameManager.gameManager.records = data.records;
                GameManager.gameManager.bestPlayer = data.records[0].name;
                GameManager.gameManager.highestScore = data.records[0].score;
            }
        }
    }

    public static void ClearData()
    {
        GameManager.gameManager.bestPlayer = "";
        GameManager.gameManager.highestScore = 0;
        GameManager.gameManager.records.Clear();
        SaveData();
    }
}
