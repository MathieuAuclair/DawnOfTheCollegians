/* DOCUMENTATION
 this the class that Idle.cs, Move.cs and Attack.cs inherit from
 */
using UnityEngine;

class StateManager
{
    protected Mob mob;
    protected GameObject player;
    protected void StateUpdate() { }
    protected void OnEnterState() { }
    protected void OnExitState() { }
    public StateManager(Mob mobGameObject, GameObject playerGameObject)
    {
        mob = mobGameObject;
        player = playerGameObject;
    }
}

