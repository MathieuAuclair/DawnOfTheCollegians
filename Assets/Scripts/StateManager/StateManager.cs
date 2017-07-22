/* DOCUMENTATION
 this the class that Idle.cs, Move.cs and Attack.cs inherit from,
 this class is used in zombieAI_1.cs
 *
 Depend from the mob that have StateManager (mobClass in zombieAI_1.cs)
 */
using UnityEngine;

// Analysis disable once CheckNamespace
public abstract class State
{
    public float distance;
    protected float x, y;
    protected Mob mob;

    public State(Mob mobGameObject)
    {
        mob = mobGameObject;
    }

	public virtual void StateUpdate()
    {
        //update for every state
    }

    public void CheckChanges() // called with the update
    {
        x = (mob.player.transform.position.x - mob.body.transform.position.x);//check distance beetween zombie and player
        y = (mob.player.transform.position.y - mob.body.transform.position.y);//
        distance = Mathf.Sqrt(Mathf.Pow(x, 2) + Mathf.Pow(y, 2));             //
        if (distance < mob.mobViewRange)// if distance is good, change the state to attack
        {
            OnExitState(2);
            OnEnterState();
        }
        else if (mob.mobTimer > mob.mobStateTime) // if time is over, then change state
        {
            mob.oldState = mob.currentState; // Completely ugly!! but works for now! //this is a switch to change state
            if (mob.currentState == 0)       // Temporary...
                mob.currentState = 1;        //
            else                             //
                mob.currentState = 0;        //
            mob.stateList[mob.oldState].OnEnterState();                // init state, and then change it
            mob.stateList[mob.oldState].OnExitState(mob.currentState); //
        }
    }
	public virtual void OnEnterState() //init every shared value 
    {
        x = 0;
        y = 0;
        distance = 0;
        mob.mobTimer = 0;
    }
	public virtual void OnExitState(int stateId) // change the state
    {
        mob.currentState = stateId;
    }
}

