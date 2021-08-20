using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUseTest : MonoBehaviour
{
    List<ItemBase> items = new List<ItemBase>();
    private void Start()
    {
        items.Add(new ItemPortion());
        items.Add(new ItemMagicPortion());
        items.Add(new ItemElixir());

        ItemBase useItem = items[0];
        Debug.Log("１つ目のアイテムを使った");
        useItem.Use();

        useItem = items[1];
        Debug.Log("２つ目のアイテムを使った");
        useItem.Use();

        useItem = items[2];
        Debug.Log("３つ目のアイテムを使った");
        useItem.Use();
    }
}