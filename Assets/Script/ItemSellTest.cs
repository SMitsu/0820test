using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSellTest : MonoBehaviour
{
    List<ItemBase> items = new List<ItemBase>();
    private void Start()
    {
        items.Add(new ItemPortion());
        items.Add(new ItemMagicPortion());
        items.Add(new ItemElixir());

        SellItem(0);
        SellItem(1);
        SellItem(2);
    }
    private void SellItem(int index)
    {
        ItemBase useItem = items[index];
        Debug.Log(index + 1 + "のアイテムを売った");
        useItem.Sell();
    }
}