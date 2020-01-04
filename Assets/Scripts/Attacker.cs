using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(0,10)] float currentSpeed = 1f; //this attribute can be changed in the animation event.  
    GameObject currentTarget;
    
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * currentSpeed);
    }

    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }

    public void Attack(GameObject target)
    {
        GetComponent<Animator>().SetBool("IsAttacking",true);
        currentTarget = target;
        Debug.Log("I'm attacking");
    }
}
