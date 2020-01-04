using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Juju : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        GameObject target = other.gameObject;
        var defender = target.GetComponent<Defender>();
        if(target.GetComponent<Defender>())
        {
            Debug.Log("touch defender");
            GetComponent<Attacker>().Attack(target);
        }
        

    }
}
