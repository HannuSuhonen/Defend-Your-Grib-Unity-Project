using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("Timer in real world seconds")]
    [SerializeField] float LevelTimer = 10f;

    private void Update() 
    {
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / LevelTimer;   
        bool timerFinished = Time.timeSinceLevelLoad >= LevelTimer; 
        if(timerFinished)
        {
            //Debug.Log("Level timer finished!");
        }
    }
}
