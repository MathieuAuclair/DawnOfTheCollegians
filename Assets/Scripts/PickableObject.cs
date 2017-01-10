using UnityEngine;
using System.Collections;

public class PickableObject : MonoBehaviour {

    public int distToPick = 5;

	// Update is called once per frame
	void FixedUpdate () {


        if( Input.GetButton("e"))
        {
            //get the distance between the object and the player 
            Vector3 playerPos = GameObject.Find("player").transform.position;
            float dist =Mathf.Sqrt( Mathf.Pow(Mathf.Abs(this.transform.position.x - playerPos.x), 2) + Mathf.Pow(Mathf.Abs(this.transform.position.y - playerPos.y), 2) );

            if( dist < this.distToPick)
            {

            }
        }
               
     }
}
