using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPortion : ItemBase
{
    public override void Use()
    {
        Debug.Log("HPが回復した");
    }
    public override int Sell()
    {
        Debug.Log(30);
        return 0;
    }
}