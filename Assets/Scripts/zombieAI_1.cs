/* DOCUMENTATION
 to make this script work, you need a player with the tag "Player", and a zombie on witch you
 will drop this script, you must put in relation the player and the script by adding the player 
 to the script component from the zombie.
 */
 using UnityEngine;

public class zombieAI_1 : MonoBehaviour {

    [Header("Zombie Speed:")]
    public float publicSpeed;
    [Header("Zombie View Range")]
    public float publicRange;


    void Start()
    {
        Mob zombie = new Mob(this.gameObject, publicSpeed, publicRange);
    }
    void Update()
    {
        
    }


    
}

public class Mob {
    private StateManager[] stateList = new StateManager[3];
    public GameObject player;
    public GameObject body;
    public float zombieSpeed = 0.01f;
    public float zombieViewRange = 2;
    public Mob(GameObject mobGameObject, float speed, float range)
    {
        body = mobGameObject;
        stateList[0] = new Idle(this);
        stateList[1] = new Move(this);
        stateList[2] = new Attack(this, player);
    }
}