using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    [SerializeField] GameObject winLabel;
    [SerializeField] GameObject loseLabel;
    Slider slider;

    void Awake() 
    {
        slider = FindObjectOfType<Slider>();
    }

    void Start()
    {
        winLabel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Attacker[] attackers = FindObjectsOfType<Attacker>();
        if(attackers.Length <= 0 && slider.value >= 1)
        {
            if(loseLabel.activeSelf) return;
            StartCoroutine(HandleWinCondition());
        }
    }

    IEnumerator HandleWinCondition()
    {
        winLabel.SetActive(true);
        //Time.timeScale = 0;
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(1);
    }

    public void ResetLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public bool SetSpawn()
    {
        if(slider.value < 1)
        {
            return true;
        }
        return false;
    }
}
