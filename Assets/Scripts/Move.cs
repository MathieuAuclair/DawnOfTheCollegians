/* DOCUMENTATION
 this is a class that inherit from StateManager.cs, it controls the behaviors
 of the zombie when he's in the move State
 */
using UnityEngine;

class Move : StateManager
{
    public Move(Mob mobObject) : base(mobObject) { }

}

