/*
*	this script set up everything when a player pick an object on the ground
*	the script take the first item in the list of near Item and set it as the
*	current Item.
*
*	note this script must be applied on every player
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObjectPickUp : MonoBehaviour {
	InteractionObjectFunction interaction;
	void Update () {
		if (Input.GetButton ("Fire1")) {
			Debug.Log ("weapon is being picked up!");
			GameObject PickUpObject = this.GetComponent<PlayerObjectInteraction> ().InProximityObject[0];
			interaction = PickUpObject.GetComponent<ObjectPropreties> ().ObjectType.UseObject;
			this.gameObject.GetComponent<PlayerObjectInteraction> ().useObject = interaction;
		}
	}
}
