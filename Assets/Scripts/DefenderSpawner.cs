using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] GameObject defender;
    private void OnMouseDown()
    {
        Debug.Log("mouse was clicked");
        Instantiate(defender, Input.mousePosition, Quaternion.identity);
    }
}
 