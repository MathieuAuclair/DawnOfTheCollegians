/*
* this script hold all propreties for the object, it's currently empty but later we will
* be able to use it to fill more info about tools or weapon that we add.
* 
* note this script must be applied on every pickable object!
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPropreties : MonoBehaviour {
	public InteractableObject ObjectType = new SmashingWeapon();
}
