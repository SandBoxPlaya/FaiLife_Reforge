using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu_Scripts : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Text_box");
    }

    public void Settings_OnClick()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
