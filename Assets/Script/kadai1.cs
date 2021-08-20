using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kadai1 : MonoBehaviour
{
    public int BuyAmount = 10;
    private void Start()
    {
        if (BuyAmount < 10)
        {
            Debug.Log(BuyAmount * 100);
        }
        else if (BuyAmount < 20)
        {
            Debug.Log(BuyAmount * 95);
        }
        else
        {
            Debug.Log(BuyAmount * 90);
        }
    }
}