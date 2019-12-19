using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] float projectileSpeed = 2f;

    GameObject projectile;

    private void Start()
    {
        Debug.Log(gameObject.transform.GetChild(0).position);
    }

    public void ShootProjectile()
    {
        projectile = Instantiate(projectilePrefab, 
        gameObject.transform.GetChild(0).position, Quaternion.identity);
    }
}
