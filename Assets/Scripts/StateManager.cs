/* DOCUMENTATION
 this the class that Idle.cs, Move.cs and Attack.cs inherit from,
 this class is used in zombieAI_1.cs
 */
using UnityEngine;

public abstract class StateManager
{
    protected Mob mob;
    protected void StateUpdate() { }
    protected void OnEnterState() { }
    protected void OnExitState() { }
    public StateManager(Mob mobGameObject)
    {
        mob = mobGameObject;
    }
}

