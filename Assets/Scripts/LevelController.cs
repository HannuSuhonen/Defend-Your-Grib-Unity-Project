using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    Slider slider;
    void Start()
    {
        slider = FindObjectOfType<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        Attacker[] attackers = FindObjectsOfType<Attacker>();
        if(attackers.Length <= 0 && slider.value >= 1)
        {
            Debug.Log("End Game!");
        }
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
