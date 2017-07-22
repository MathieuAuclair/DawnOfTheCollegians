using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {
    public int timeBetweenSpawn;
    private float timeToNextSpawn;
	// Use this for initialization
	void Start () {
        timeBetweenSpawn = 2;
        timeToNextSpawn = 0;
    }
	
	// Update is called once per frame
	void Update () {
        timeToNextSpawn += Time.deltaTime;
        if (timeToNextSpawn >= timeBetweenSpawn )
        {
            timeToNextSpawn = 0;
           // GameObject enemy = (GameObject)Instantiate(GameObject.FindGameObjectWithTag("Monster") );  // just add the good Tag 
            //enemy.transform.position = this.transform.position;
     
        }
    }
}
