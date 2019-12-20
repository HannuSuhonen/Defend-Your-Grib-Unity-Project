using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health = 100;
    [SerializeField] GameObject deathVFX;

    public void DealDamage(int damage) //Pass in an integer for damage in projectile.cs
    {
        health -= damage;
        if(health <= 0)
        {
            TriggerVFX();
            Destroy(gameObject);
        }
    }

    private void TriggerVFX()
    {
        if (!deathVFX)
        {
            return;
        }
        GameObject deathVFXObject = Instantiate(deathVFX,
        transform.position, Quaternion.identity) as GameObject;
        Destroy(deathVFXObject, 1f);
    }
}
