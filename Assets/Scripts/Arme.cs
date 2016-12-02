using UnityEngine;
using System.Collections;

public class Arme : MonoBehaviour {

    protected string nom;
    protected int durabilite;
    protected float degatBase;
    protected float vitesseAtt;


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
                monster.GetComponent<>();
            }
        }
    }
}
