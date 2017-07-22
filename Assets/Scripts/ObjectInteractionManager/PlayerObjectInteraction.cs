using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObjectInteraction : MonoBehaviour {
	//this list avoid using 2 object at the same time
	public List<GameObject> InProximityObject = new List<GameObject>();

	public void RemoveItemFromProximity(GameObject usedObject){
		for (int i = 0; i < InProximityObject.Count; i++) {
			if (InProximityObject[i] == usedObject) {
				InProximityObject.RemoveAt (i);
			}
		}
	}
}
