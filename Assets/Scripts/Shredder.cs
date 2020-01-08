using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shredder : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        FindObjectOfType<HealthDisplay>().HealthSubtract();
    }
}
