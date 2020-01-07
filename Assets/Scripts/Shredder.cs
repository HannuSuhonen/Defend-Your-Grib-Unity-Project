using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shredder : MonoBehaviour
{
    HealthDisplay healthDisplay;
    private void Start() 
    {
        healthDisplay = FindObjectOfType<HealthDisplay>();
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        healthDisplay.HealthSubtract();
    }
}
