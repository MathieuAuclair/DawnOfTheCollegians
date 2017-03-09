/* DOCUMENTATION
 this is a class that inherit from StateManager.cs, it controls the behaviors
 of the zombie when he's in the move State
 */
using UnityEngine;

class Move : State
{
    private GameObject mobBody;
	private float movex, movey;

    public Move(Mob mobObject) : base(mobObject) {
        mobBody = mobObject.body;
    }

	public override void OnEnterState()
    {
		movex = Random.Range(-1, 2); // range of speed in x, and y
		movey = Random.Range(-1, 2); //
		distance = 0;
		mob.mobTimer = 0;
    }

	public override void StateUpdate()
	{
		mob.body.transform.Translate((movex * mob.mobSpeed * Time.deltaTime * 15), (movey * mob.mobSpeed * Time.deltaTime * 15), 0);
    }
}

