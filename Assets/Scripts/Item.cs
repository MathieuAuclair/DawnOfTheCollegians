using UnityEngine;
using System.Collections;

public class Item {

    protected string name;
    protected ItemType itemType;

    public string GetName()
    {
        return this.name;
    }

    public ItemType GetType()
    {
        return this.itemType;
    }


}
