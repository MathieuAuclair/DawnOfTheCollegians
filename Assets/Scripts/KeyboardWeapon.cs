using UnityEngine;
using System.Collections;

public class KeyboardWeapon : Weapon {

    public KeyboardWeapon()
    {
        this.name = "KeyboardWeapon";
        this.itemType = ItemType.Keyboard;
        this.baseDamage = 3;
        this.speedAtt = 1;
        this.durability = 2;
    }
}
