/* DOCUMENTATION
 this is a class that inherit from StateManager.cs, it controls the behaviors
 of the zombie when he's in the move State
 */
using UnityEngine;

class Move : State
{
    private GameObject mobBody;
    public Move(Mob mobObject) : base(mobObject) {
        mobBody = mobObject.body;
    }
    private System.Random random = new System.Random();
    new public void OnEnterState()
    {
        x = random.Next(-5, 5); // range of speed in x, and y
        y = random.Next(-5, 5); //
    }

    public void StateUpdate()
    {
        Debug.Log("move");
        mobBody.transform.Translate(x, y, 0);
    }
}

