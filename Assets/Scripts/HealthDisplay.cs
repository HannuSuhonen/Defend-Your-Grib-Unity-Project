using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthDisplay : MonoBehaviour
{

    Text healthDisplay;
    [SerializeField] GameObject loseLabel;
    [SerializeField] Slider difficultySlider;
    [SerializeField] float baseLives = 6f; //We use baselives to flip slider from left to right for:  easy <-> hard 
    int healthLoss = 1;
    int sceneLoadDelay = 2;
    float health = 5;

    // Start is called before the first frame update
    void Start()
    {
        health = baseLives - PlayerPrefsController.GetMasterDifficulty();
        loseLabel.SetActive(false);
        healthDisplay = GetComponent<Text>();
        healthDisplay.text = health.ToString();
        Debug.Log("Current difficulty at playerprefs controller is: " + PlayerPrefsController.GetMasterDifficulty());
    }

    public void HealthSubtract()
    {
        health -= healthLoss;
        if(health < 0 ) return;
        healthDisplay.text = health.ToString();
        StartCoroutine(LoadStartScene());
    }

    IEnumerator LoadStartScene()
    {
        if(health <= 0)
        {
            yield return new WaitForSeconds(sceneLoadDelay);
            loseLabel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
