using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [SerializeField] [Range(0,10)] float walkingSpeed = 1f;
    [SerializeField] AnimationClip spawnAnimation;

    void Update()
    {
        StartCoroutine(Walk());
    }

    private IEnumerator Walk()
    {
        if (spawnAnimation != null) //checks to see if spawn animation exists. 
        {
            yield return new WaitForSeconds(spawnAnimation.length);
        }
        transform.Translate(Vector2.left * Time.deltaTime * walkingSpeed);
    }
}