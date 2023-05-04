using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Application Quit");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Kamera");
    }

    public void BackButton()
    {
        SceneManager.LoadScene("Scene_UI1");
    }
}
