using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSellTest2 : MonoBehaviour
{
    List<ItemBase> items = new List<ItemBase>();
    private void Start()
    {
        items.Add(new ItemPortion());
        items.Add(new ItemMagicPortion());
        items.Add(new ItemElixir());

        SellItem(2);
    }
    private void SellItem(int index)
    {
        ItemBase useItem = items[index];
        useItem.Sell();
        items.Remove(useItem);
    }
}