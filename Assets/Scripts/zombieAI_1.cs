/* DOCUMENTATION
 to make this script work, you need a player with the tag "Player", and a zombie on witch you
 will drop this script, you must put in relation the player and the script by adding the player 
 to the script component from the zombie.
 */
 using UnityEngine;

public class zombieAI_1 : MonoBehaviour {

    //inspector
    [Header("Zombie Speed:")]
    public float publicSpeed;
    [Header("Zombie View Range")]
    public float publicRange;
    [Header("Time to change state")]
    public float publicTimer;
    [Header("player gameObject")]
    public GameObject publicPlayer;

    //global
    Mob zombie;

    void Start()
    {
        zombie = new Mob(this.gameObject, publicPlayer, publicSpeed, publicRange, publicTimer);
    }
    void Update()
    {
        zombie.MobUpdate();
    }
    
}

public class Mob {
    public State[] stateList = new State[3];
    public GameObject player, body;    // gameObject used
    public int currentState;          // just an index pointer
    public int oldState;             // container
    public float mobSpeed, mobViewRange, mobTimer, mobStateTime;

	public Mob(GameObject mobGameObject, GameObject playerGameObject, float speed, float range, float timer)
	{
		mobStateTime = timer; //time between every state
		mobSpeed = speed;            
		mobViewRange = range;
		body = mobGameObject;
		player = playerGameObject;
		currentState = 1;
		stateList[0] = new Idle(this);           // Add state to the mob  
		stateList[1] = new Move(this);           //
		stateList[2] = new Attack(this);         //
	}

    public void MobUpdate()
    {
        stateList[currentState].CheckChanges(); //check for stateChanges
		stateList[currentState].StateUpdate(); //do the update for state
	//	Debug.Log(currentState);
        mobTimer += Time.deltaTime;           //add time
    }
}