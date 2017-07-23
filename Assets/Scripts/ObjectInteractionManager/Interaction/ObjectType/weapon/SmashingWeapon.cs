/*	
 * this is an object type that inherit from InteractibleObject
 * 
 * note no need to apply anywhere
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmashingWeapon : InteractableObject {
	public override void UseObject(){
		Debug.Log ("weapon is being used!");

	}
}
