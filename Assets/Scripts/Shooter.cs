using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab,gunPositionPrefab;
    [SerializeField] float projectileSpeed = 2f;


    public void ShootProjectile()
    {
        Instantiate(projectilePrefab, gunPositionPrefab.transform.position
        , Quaternion.identity);
    }
}
