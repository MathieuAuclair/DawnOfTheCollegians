using UnityEngine;
using System.Collections;

public enum ItemType
{
    Keyboard,
    Screen,
    Bat,
    Basketball
}

public static class ItemFactory {

    static public Item createItem(ItemType type)
    {
        Item newItem = null;
        switch (type)
        {
            case ItemType.Keyboard:
                newItem = new KeyboardWeapon();
                break;
            case ItemType.Screen:
                break;
            case ItemType.Bat:
                break;
            case ItemType.Basketball:
                break;
        }

        return newItem;   
    }
}
