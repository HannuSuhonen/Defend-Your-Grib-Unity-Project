using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] float projectileSpeed = 2f;

    public void ShootProjectile()
    {
        Instantiate(projectilePrefab, 
        gameObject.transform.GetChild(0).position, Quaternion.identity);
    }
}
