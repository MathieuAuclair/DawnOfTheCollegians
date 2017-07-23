using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PickableObjectEditor : ScriptableWizard {
	public Sprite ObjectSprite;
	public string ObjectName = "Object";
	public string ObjectTag = "Default";
	public Color ObjectColor = Color.white;

	[MenuItem ("ObjectManager/Create A Pickable Object %g")]
	static void CreatePickableObject(){
		ScriptableWizard.DisplayWizard<PickableObjectEditor> ("Create New Object","Create New","Update Selected");
	}

	void OnWizardCreate(){
		GameObject ObjectPrefab = Instantiate(Resources.Load("PickableObject")) as GameObject;
		setObjectComponent (ObjectPrefab);
	}

	void OnWizardOtherButton(){
		if(Selection.activeTransform != null){
			GameObject ObjectPrefab = Selection.activeTransform.gameObject;
			if (ObjectPrefab != null) {
				setObjectComponent (ObjectPrefab);
			}
		}	
	}

	void setObjectComponent(GameObject ObjectPrefab){
		ObjectPrefab.name = ObjectName;
		ObjectPrefab.tag = ObjectTag;
		ObjectPrefab.GetComponent<SpriteRenderer> ().sprite = ObjectSprite;
		ObjectPrefab.GetComponent<SpriteRenderer> ().color = ObjectColor;
		ObjectPrefab.GetComponent<SpriteRenderer>().sortingLayerName = "tools";
	}

	void OnWizardUpdate(){
		helpString = "Enter Character Details";
	
	}
}


