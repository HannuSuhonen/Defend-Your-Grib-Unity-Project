using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] [Range(0,10)] float movementSpeed = 1f;
    float rotationSpeed = 75f;

    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * movementSpeed);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hit");
    }
}
