using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMagicPortion : ItemBase
{
    public override void Use()
    {
        Debug.Log("MPが回復した");
    }

    public override int Sell()
    {
        Debug.Log(80);
        return 0;
    }
}