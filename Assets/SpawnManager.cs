using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {
    public int timeBetweenSpawn;
    private float timeToNextSpawn;
	// Use this for initialization
	void Start () {
        timeBetweenSpawn = 5;
        timeToNextSpawn = 0;
    }
	
	// Update is called once per frame
	void Update () {
        timeToNextSpawn += Time.deltaTime;
        if (timeToNextSpawn >= timeBetweenSpawn )
        {
     /*     GameObject go = (GameObject)Instantiate(Resources.Load("MyPrefab"));  // need to test with a prefab
            go.transform.position = this.transform.position;
            timeToNextSpawn = 0; 
            */
        }
	}
}
