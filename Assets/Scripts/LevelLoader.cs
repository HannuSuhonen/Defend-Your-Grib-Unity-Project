using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
        Time.timeScale = 1;
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadOptionsMenu()
    {
        SceneManager.LoadScene(3);
    }
}
