using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    Animator animations;
    const  int MaxHitPoint = 10;

    public int hitPoint = MaxHitPoint;
    public bool canBeHit = true;

    public Item[] inventory = new Item[8];
    Weapon activeWeapon = null;
    Weapon backupWeapon = null;

    public float speed;
    private Rigidbody2D rb;
    private Vector3 target;
    public Text txtGameOver;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = transform.position;
        //txtGameOver = GameObject.Find("Text").GetComponent<Text>();
        animations = GetComponent<Animator>();
    }

    // Update is called once per frame
     void FixedUpdate () {

    /*First script movement with translation, need to configure the speed parametre and make sure you have a RB2D On*/

    float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        transform.Translate(Vector2.right * moveHorizontal * Time.deltaTime *speed);
        transform.Translate(Vector2.up * moveVertical * Time.deltaTime * speed);
    

    /*Second Script movement with forces ,  need to configure the speed parametre and make sure you have a RB2D On

    float moveHorizontal = Input.GetAxis("Horizontal");
    float moveVertical = Input.GetAxis("Vertical");
    Vector2 movement = new Vector2(moveHorizontal, moveVertical);
    rb.AddForce(movement*speed);
    */


    }
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        if (h != 0 || v != 0)
        {
            animations.SetBool("ismoving", true);
        }
        else
            animations.SetBool("ismoving", false);
        Debug.Log(h + " " + v);
    }
    /* Third script movement with OnClick command, need to configure the speed parametre. You dont NEED RB2D.
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
        }
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
    
    */
    //This function detect collision with an other object if his tag  is Zombie, need a RB2D and a box colision on each ,
    //note that the player's box colision IsTrigger parametre  must be On
    void OnTriggerEnter2D(Collider2D other)
    {
        
        float diffX = transform.position.x - other.transform.position.x;
        float diffY = transform.position.y - other.transform.position.y;
        Vector2 mouvement = new Vector2(diffX, diffY);


        if (other.gameObject.tag == "Zombie" && canBeHit == true)
        {
            if(hitPoint -1 <= 0)
            {
                gameOver();
            }
            else
            {
                hitPoint--;
                rb.AddForce(mouvement*100);
            }
        }
    }

    public void AddItem(Item newItem)
    {
        int i = 0;
        bool findSpot = false;
        while(!findSpot && i < this.inventory.Length )
        {
            //search for an empty space in the inventory
            if (this.inventory[i] == null)
            {
                findSpot = true;
                this.inventory[i] = newItem;
                Debug.Log(newItem.GetName());
                // if a weapon is found, check if the player have one already equip
                // if not, places it at the main 
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


    void getHit(int dmg)
    {
        
    }
    void imunity(int secImun)
    {

    }

    void gameOver()
    {
        txtGameOver.text = "WOW T'ES MORT!";
    }
}
