using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    const int MaxHitPoint = 100;
    public int hitPoint = MaxHitPoint;
    public Item[] inventory = new Item[8];
    Weapon activeWeapon = null;
    Weapon backupWeapon = null;
    public float speed;
    private Rigidbody2D rb;
    private Vector3 target; 



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = transform.position;
    }

    // Update is called once per frame
    //void FixedUpdate () {

    /*First script movement with translation, need to configure the speed parametre and make sure you have a RB2D On

    float moveHorizontal = Input.GetAxis("Horizontal");
    float moveVertical = Input.GetAxis("Vertical");

    Vector2 movement = new Vector2(moveHorizontal, moveVertical);
    rb.AddForce(movement);
    this.transform.position.x += moveVertical * speed;
    this.transform.position.y += moveVertical * speed;
    */

    /*Second Script movement with forces ,  need to configure the speed parametre and make sure you have a RB2D On

    float moveHorizontal = Input.GetAxis("Horizontal");
    float moveVertical = Input.GetAxis("Vertical");
    Vector2 movement = new Vector2(moveHorizontal, moveVertical);
    rb.AddForce(movement*speed);
    */


    //}
    /* Third script movement with OnClick command, need to configure the speed parametre. You dont NEED RB2D.*/
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
        }
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
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
