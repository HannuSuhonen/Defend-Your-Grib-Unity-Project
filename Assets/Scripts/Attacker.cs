using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(0,10)] float currentSpeed = 1f;
    //[SerializeField] AnimationClip spawnAnimation;

    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * currentSpeed);
    }

    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }

    /*
    private IEnumerator Walk()
    {
        if (spawnAnimation != null) //checks to see if spawn animation exists. 
        {
            yield return new WaitForSeconds(spawnAnimation.length);
        }
        transform.Translate(Vector2.left * Time.deltaTime * walkingSpeed);
    }*/
}