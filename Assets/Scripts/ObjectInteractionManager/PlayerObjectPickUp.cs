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

public class PlayerObjectPickUp : MonoBehaviour { //need a lot of improvement!
	InteractionObjectFunction interaction;
	void Update () {
		//check if some weapons are available
		if (Input.GetButton ("Fire1") && this.GetComponent<PlayerObjectInteraction> ().InProximityObject.Count > 0) {
			PlayerObjectInteraction playerObjectInteraction = this.gameObject.GetComponent<PlayerObjectInteraction> ();

			//remove old weapon
			if(playerObjectInteraction.currentGameObject != null)
				playerObjectInteraction.currentGameObject.transform.parent = null;

			//set weapon type
			GameObject PickUpObject = playerObjectInteraction.InProximityObject[0];
			interaction = PickUpObject.GetComponent<ObjectPropreties> ().ObjectType.UseObject; //get new object interaction function
			playerObjectInteraction.useObject = interaction; //set new object interaction function


			//set visual weapon
			playerObjectInteraction.currentGameObject = PickUpObject;
			PickUpObject.transform.position = this.transform.position - new Vector3(0,0.1f,0);
			PickUpObject.transform.parent = this.transform;
		}
	}
}
