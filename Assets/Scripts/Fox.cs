using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        GameObject target = other.gameObject;
        if(target.GetComponent<Gravestone>())
        {
            GetComponent<Animator>().SetTrigger("JumpTrigger");
        }
        else if(target.GetComponent<Defender>())
        {
            GetComponent<Attacker>().Attack(target);
        }
    }
}
