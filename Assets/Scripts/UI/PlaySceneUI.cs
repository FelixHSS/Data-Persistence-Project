using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaySceneUI : MonoBehaviour
{
    public void GoBackMenu()
    {
        SceneManager.LoadScene(0);
    }
}
