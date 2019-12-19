using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab;

    private void Start()
    {
        Debug.Log(gameObject.transform.GetChild(0).position);
    }

    public void ShootProjectile()
    {
        GameObject projectile = Instantiate(projectilePrefab, 
            gameObject.transform.GetChild(0).position, Quaternion.identity);
        Destroy(projectile,1f);
    }
}
