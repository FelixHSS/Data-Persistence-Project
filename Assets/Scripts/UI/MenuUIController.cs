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
        SetUserName();
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

    void SetUserName()
    {
        GameManager.gameManager.currentPlayer = userName.text;
    }

    public void ClearData()
    {
        ManageData.ClearData();
        record.text = GameManager.gameManager.GetReocrd();
    }
}
