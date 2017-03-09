/* DOCUMENTATION
 this is a class that inherit from StateManager.cs, it controls the behaviors
 of the zombie when he's in the attack State
 */
using UnityEngine;

class Attack : State
{
    public Attack(Mob mobGameObject) : base(mobGameObject){}
	public override void OnEnterState()
    {
        mob.mobTimer = 0;
    }
	public override void StateUpdate()
    {
        if (distance < mob.mobViewRange)
        {
            mob.body.transform.Translate(x / distance * mob.mobSpeed, y / distance * mob.mobSpeed, 0);
        }
    }
}
