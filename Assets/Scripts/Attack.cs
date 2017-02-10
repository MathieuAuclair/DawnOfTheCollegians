/* DOCUMENTATION
 this is a class that inherit from StateManager.cs, it controls the behaviors
 of the zombie when he's in the attack State
 */
using UnityEngine;

class Attack : StateManager
{
    public Attack(Mob mobGameObject, GameObject playerGameObject) : base(mobGameObject, playerGameObject) { }
    private float x, y, distance;

    new void StateUpdate()
    {
        x = (player.transform.position.x - mob.body.transform.position.x);
        y = (player.transform.position.y - mob.body.transform.position.y);
        distance = Mathf.Sqrt(Mathf.Pow(x, 2) + Mathf.Pow(y, 2));

        if (distance < mob.zombieViewRange)
        {
            mob.body.transform.Translate(x / distance * mob.zombieSpeed, y / distance * mob.zombieSpeed, 0);
        }
    }
}
