using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab,gunPositionPrefab;
    [SerializeField] float projectileSpeed = 2f;

    AttackerSpawner myLaneSpawner;
    Animator animator;

    private void Start()
    {
        SetSpawnLane();
        animator = GetComponent<Animator>();

    }

    private void Update()
    {
        if(IsAttackerInLane())
        {
            animator.SetBool("IsAttacking",true);
        }
        else
        {
            animator.SetBool("IsAttacking",false);
        }
    }

    private void SetSpawnLane()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();
        foreach(AttackerSpawner spawner in spawners)
        {
            bool IsCloseEnough = (Mathf.Abs(spawner.transform.position.y - transform.position.y) <=  Mathf.Epsilon); // <= mathf.epsilon
            if(IsCloseEnough)
            {
                myLaneSpawner = spawner;
            }
        }
    }

    private bool IsAttackerInLane()
    {
        if(myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void ShootProjectile()
    {
        Instantiate(projectilePrefab, gunPositionPrefab.transform.position
        , Quaternion.identity);
    }
}
