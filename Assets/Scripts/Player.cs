using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public Item[] inventory = new Item[8];
    Weapon activeWeapon = null;
    public float speed;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate () {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rb.AddForce(movement * speed);

    }
    public void addItem(Item newItem)
    {
        int i = 0;
        bool findSpot = false;
        while(!findSpot && i < this.inventory.Length )
        {
            if (this.inventory[i] == null)
            {
                findSpot = true;
                this.inventory[i] = newItem;
                Debug.Log(newItem.getName());
            }
            else
                i++;
       }
    }
}
