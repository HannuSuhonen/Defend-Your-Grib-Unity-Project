using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] [Range(0,10)] float movementSpeed = 1f;
    float rotationSpeed = 75f;
    Health health;

    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * movementSpeed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        health = other.GetComponent<Health>();
        if (!health)
        {
            return;
        }
        health.DealDamage();
        Destroy(gameObject);
    }
}
