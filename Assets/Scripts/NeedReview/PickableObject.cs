using UnityEngine;
using System.Collections;

public class PickableObject : MonoBehaviour {

    public int distToPick = 5;
    public ItemType type;
        
	// Update is called once per frame
	void FixedUpdate () {

        if( Input.GetKey("e"))
        {
            //get the distance between the object and the player 
            GameObject player = GameObject.Find("Player");
            Vector3 playerPos = player.transform.position;
            float dist = Mathf.Sqrt( Mathf.Pow(Mathf.Abs(this.transform.position.x - playerPos.x), 2) + Mathf.Pow(Mathf.Abs(this.transform.position.y - playerPos.y), 2) );

            Debug.Log(dist);
            if( dist < this.distToPick)
            {
                player.GetComponent<Player>().AddItem(ItemFactory.createItem(type));
                Destroy(gameObject);
            }
        }
    }
}
