using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField]int waitForSeconds = 3;
    void Start()
    {
        StartCoroutine(WaitForTime());
    }

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(waitForSeconds);
        LoadNextScene(); 
    }

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
