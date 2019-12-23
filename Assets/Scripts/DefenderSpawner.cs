using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] GameObject defender;
    private void OnMouseDown()
    {
        Debug.Log("mouse was clicked");
        SpawnDefender();
    }

    private void SpawnDefender()
    {
       GameObject newDefender = Instantiate(defender, 
           Camera.main.ScreenToWorldPoint((Vector2)Input.mousePosition), 
           Quaternion.identity);
        Debug.Log((Vector2)Input.mousePosition);
    }
}
 