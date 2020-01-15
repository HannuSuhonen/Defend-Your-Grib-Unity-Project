using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] [Range(0,10)] float movementSpeed = 1f;
    [SerializeField] int damage = 100;
    [SerializeField] GameObject explosionPrefab;
    float rotationSpeed = 75f;

    GameObject parentProjectile;
    const string PARENT_PROJECTILE = "Projectiles";

    private void Start() 
    {
        CreateProjectileParent();
    }

    private void CreateProjectileParent()
    {
        parentProjectile = GameObject.Find(PARENT_PROJECTILE);
        if(!parentProjectile)
        {
            parentProjectile = new GameObject(PARENT_PROJECTILE);
        }
        gameObject.transform.parent = parentProjectile.transform;
    }

    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * movementSpeed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var health = other.GetComponent<Health>();
        var attacker = other.GetComponent<Attacker>();

        if(attacker && health)
        {
            GameObject explosion = Instantiate(explosionPrefab,transform.position,Quaternion.identity);
            health.DealDamage(damage);
            Destroy(explosion,5f);
            Destroy(gameObject);
        }
        if (!health)
        {
            return;
        }
    }
}
