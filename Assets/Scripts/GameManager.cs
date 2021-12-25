using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public int highestScore = 0;
    public string bestPlayer = "";
    public string currentPlayer = "";

    private void Awake()
    {
        if (gameManager != null)
        {
            Destroy(gameObject);
            return;
        }

        gameManager = this;
        DontDestroyOnLoad(gameManager);
        ManageData.LoadData();
    }

    public string GetReocrd()
    {
        string record = "Best Score: " + GameManager.gameManager.bestPlayer + ": " + GameManager.gameManager.highestScore;
        return record;
    }
}
