using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemElixir : ItemBase
{
    public override void Use()
    {
        Debug.Log("HPとMPが全快した");
    }

    public override int Sell()
    {
        Debug.Log(2000);
        return 0;
    } 
}
