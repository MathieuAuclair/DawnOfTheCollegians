/* DOCUMENTATION
 to make this script work, you need a player with the tag "Player", and a zombie on witch you
 will drop this script, you must put in relation the player and the script by adding the player 
 to the script component from the zombie.
 */
 using UnityEngine;

public class zombieAI_1 : MonoBehaviour {
    void Start()
    {
        Mob zombie = new Mob(this.gameObject);
    }
    void Update()
    {
        
    }


    
}

public class Mob {
    private StateManager[] stateList = new StateManager[3];
    public GameObject player;
    [HideInInspector]
    public GameObject body;
    public float zombieSpeed = 0.01f;
    public float zombieViewRange = 2;
    public Mob(GameObject mob)
    {
        body = mob;
        stateList[0] = new Idle(this, player);
        stateList[1] = new Move(this, player);
        stateList[2] = new Attack(this, player);
    }
}