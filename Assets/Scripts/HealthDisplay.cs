using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthDisplay : MonoBehaviour
{

    Text healthDisplay;
    [SerializeField] int health = 5;
    int healthLoss = 1;
    int sceneLoadDelay = 2;

    // Start is called before the first frame update
    void Start()
    {
        healthDisplay = GetComponent<Text>();
        healthDisplay.text = health.ToString();
    }

    public void HealthSubtract()
    {
        health -= healthLoss;
        healthDisplay.text = health.ToString();
        StartCoroutine(LoadStartScene());
    }

    IEnumerator LoadStartScene()
    {
        if(health <= 0)
        {
            yield return new WaitForSeconds(sceneLoadDelay);
            SceneManager.LoadScene(1);
        }
    }
}
