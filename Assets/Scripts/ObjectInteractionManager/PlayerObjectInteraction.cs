/*
 * this script execute pickced up object function, and its managing object in proximity,
 * this script is important, an improvement would be to split button interaction from 
 * object management.
 * 
 * note this script must be applied on every player that can pickup object
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void InteractionObjectFunction();

public class PlayerObjectInteraction : MonoBehaviour {
	public InteractionObjectFunction useObject;

	//this list avoid using 2 object at the same time
	public List<GameObject> InProximityObject = new List<GameObject>();

	public void RemoveItemFromProximity(GameObject usedObject){
		for (int i = 0; i < InProximityObject.Count; i++) {
			if (InProximityObject[i] == usedObject) {
				InProximityObject.RemoveAt (i);
			}
		}
	}

	void Update(){
		if (useObject != null && Input.GetButton("Jump")) {
			
			useObject.Invoke ();
		}
	}
}
