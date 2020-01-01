using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab,gunPositionPrefab;
    [SerializeField] float projectileSpeed = 2f;

    AttackerSpawner myLaneSpawner;

    private void Start()
    {
        SetSpawnLane();
    }

    private void Update()
    {
        if(IsAttackerInLane())
        {
            Debug.Log("shoot now!");
        }
        else
        {
            Debug.Log("Wait idly");
            //TODO: Change animation state to idle anim.
            //Create idle anim.
        }
    }

    /*private bool IsAttackerInLane()
    {
        
    }*/

    private void SetSpawnLane()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();
        foreach(AttackerSpawner spawner in spawners)
        {
            bool IsCloseEnough = (Mathf.Abs(spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon);
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
