using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
using TMPro;

public class MenuUIController : MonoBehaviour
{
    public TMP_InputField userName;
    public TextMeshProUGUI record;

    private void Start()
    {
        record.text = GameManager.gameManager.GetReocrd();
    }
    public void StartGame()
    {
        SetPlayerName();
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
    #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
    #else
        Application.Quit();
    #endif
    }

    public void GoToRecords()
    {
        SceneManager.LoadScene(2);
    }

    void SetPlayerName()
    {
        GameManager.gameManager.currentPlayer = userName.text;
    }

    public void ClearData()
    {
        ManageData.ClearData();
        record.text = GameManager.gameManager.GetReocrd();
    }
}
