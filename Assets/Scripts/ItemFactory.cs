using UnityEngine;
using System.Collections;

public enum ItemName
{
    Keyboard,
    Screen,
    Bat,
    Basketball
}

public static class ItemFactory {

    static public Item createItem(ItemName name)
    {
        Item newItem = null;
        switch (name)
        {
            case ItemName.Keyboard:
                newItem = new KeyboardWeapon();
                break;
            case ItemName.Screen:
                break;
            case ItemName.Bat:
                break;
            case ItemName.Basketball:
                break;
        }

        return newItem;   
    }
}
