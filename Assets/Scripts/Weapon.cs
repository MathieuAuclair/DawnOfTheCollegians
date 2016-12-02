using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

    protected int durability;
    protected float baseDamage;
    protected float speedAtt;


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Launch The animation here
            //chech for a hit 
            GameObject[] monsters;
            monsters = GameObject.FindGameObjectsWithTag("Monster");

            foreach (GameObject monster in monsters)
            {
                //call the hit here
                //monster.GetComponent<>();
            }
        }
    }
}
