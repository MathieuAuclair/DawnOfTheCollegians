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
