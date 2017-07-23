/*
 *	this script must be assign to every pickable object or else the player won't be able to 
 * pick the object up, a good improvement for this script would be a public int parameter
 * that can resise the flare based on the object type
 * 
 * Note this script must be used on every pickable object!
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proximityNotifier : MonoBehaviour {
	Behaviour HaloSwitch;

	void Start(){
		HaloSwitch = (gameObject.GetComponent ("Halo") as Behaviour);
	}

	void OnTriggerEnter2D(Collider2D player){
		if (player.gameObject.tag == "Player") {
			HaloSwitch.enabled = true;
			player.GetComponent<PlayerObjectInteraction> ().InProximityObject.Add(this.gameObject);
		}
	}

	void OnTriggerExit2D(Collider2D player){
		if (player.gameObject.tag == "Player") {
			HaloSwitch.enabled = false;
			player.GetComponent<PlayerObjectInteraction> ().RemoveItemFromProximity (this.gameObject);
		}
	}
}
