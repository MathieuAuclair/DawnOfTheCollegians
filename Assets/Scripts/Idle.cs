/* DOCUMENTATION
 this is a class that inherit from StateManager.cs, it controls the behaviors
 of the zombie when he's in the idle State
 */
using UnityEngine;

class Idle : State
{
    public Idle(Mob mobObject) : base(mobObject) {}

	public override void StateUpdate()
    {
        
    }
}

