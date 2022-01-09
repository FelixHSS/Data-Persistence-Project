using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class RecordSceneUI : MonoBehaviour
{
    public TextMeshProUGUI recordsText;
    // Start is called before the first frame update
    void Start()
    {
        foreach(PlayerRecord record in GameManager.gameManager.records)
        {
            recordsText.text = recordsText.text + record.ToString() + "\n";
        }
    }

    public void GoBackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
