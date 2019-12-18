using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] Attacker enemyPrefab; //using Attacker Class here as its assigned to the revelant prefab. 
    [SerializeField] bool spawn = true;
    [SerializeField] float min = 1f;
    [SerializeField] float max = 5f;

    // Start is called before the first frame update
    private IEnumerator Start()
    {
        while(spawn)
        {
            yield return new WaitForSeconds(UnityEngine.Random.Range(min, max));
            SpawnAttacker();
        }
    }

    private void SpawnAttacker()
    {
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }
}
