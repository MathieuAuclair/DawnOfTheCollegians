using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public Item[] inventory = new Item[8];
    Weapon activeWeapon = null;
    Weapon backupWeapon = null;
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
        rb.AddForce(movement);
    //    this.transform.position.x += moveVertical * speed;
     //   this.transform.position.y += moveVertical * speed;
    }
    public void AddItem(Item newItem)
    {
        int i = 0;
        bool findSpot = false;
        while(!findSpot && i < this.inventory.Length )
        {
            if (this.inventory[i] == null)
            {
                findSpot = true;
                this.inventory[i] = newItem;
                Debug.Log(newItem.GetName());
               
                if(  this.inventory[i] is Weapon)
                {
                    if (this.activeWeapon == null)
                    {
                        this.activeWeapon = (Weapon)this.inventory[i];
                        this.UpdateMainWeaponUI();
                    }
                    else if (this.backupWeapon == null)
                    {
                        this.backupWeapon = (Weapon)this.inventory[i];
                        this.UpdateBackupWeaponUI();
                    }                          
                }
            }
            else
                i++;
       }
    }

    void UpdateMainWeaponUI()
    {
        GameObject uiImage = GameObject.Find("UIWeapon1");
        uiImage.GetComponent<ImageHandler>().SetImage( this.activeWeapon.GetType() );
    }

    void UpdateBackupWeaponUI()
    {
        GameObject uiImage = GameObject.Find("UIWeapon2");
        uiImage.GetComponent<ImageHandler>().SetImage(this.backupWeapon.GetType());
    }
}
