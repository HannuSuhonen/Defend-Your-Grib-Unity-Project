using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] float projectileSpeed = 2f;
    [SerializeField] GameObject gunPositionPrefab;

    public void ShootProjectile()
    {
        Instantiate(projectilePrefab, gunPositionPrefab.transform.position
        , Quaternion.identity);
    }
    //gameObject.transform.GetChild(1).position
}
