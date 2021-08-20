using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBase
{
    public virtual void Use()
    {
        Debug.Log("何も起きなかった");
    }

    public virtual int Sell()
    {
        Debug.Log("これは売れません");
        return 0;
    }
}
