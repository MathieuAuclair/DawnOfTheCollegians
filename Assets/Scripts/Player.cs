using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    Item[] inventory = new Item[8];
    Weapon activeWeapon = null;

	// Use this for initialization
	void Start () {
              
    }
    
	// Update is called once per frame
	void Update () {
	
	}

    public void addItem(Item newItem)
    {
        for(int i=0; i< this.inventory.Length; i++)
        {
            if (this.inventory[i] == null)
            {
                this.inventory[i] = newItem;
            }
 
        }
    }
}
