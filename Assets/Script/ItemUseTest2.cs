using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUseTest2 : MonoBehaviour
{
    List<ItemBase> items = new List<ItemBase>();
    private void Start()
    {
        items.Add(new ItemPortion());
        items.Add(new ItemMagicPortion());
        items.Add(new ItemElixir());

        UseItem(0);
        UseItem(1);
        UseItem(2);
    }
    private void UseItem(int index)
    {
        ItemBase useItem = items[index];
        Debug.Log(index+1 + "つ目のアイテムを使った");
        useItem.Use();
    }
}