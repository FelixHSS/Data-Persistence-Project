using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public int highestScore = 0;
    public string userName = "";

    private void Awake()
    {
        if (gameManager != null)
        {
            Destroy(gameObject);
            return;
        }

        gameManager = this;
        DontDestroyOnLoad(gameManager);
    }
}
