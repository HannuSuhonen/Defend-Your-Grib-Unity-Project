using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] float projectileSpeed = 2f;

    public void ShootProjectile()
    {
        Instantiate(projectilePrefab, 
        gameObject.transform.GetChild(0).position, Quaternion.identity);
    }
}
