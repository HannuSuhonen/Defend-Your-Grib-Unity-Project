using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health = 100;
    [SerializeField] int damage = 100;
    [SerializeField] GameObject deathVFX;

    Projectile projectile;

    public void DealDamage()
    {
        health -= damage;
        if(health <= 0)
        {
            GameObject explosion = Instantiate(deathVFX, 
                transform.position,Quaternion.identity) as GameObject;
            Destroy(explosion,1f);
            Destroy(gameObject);
        }
    }
}
