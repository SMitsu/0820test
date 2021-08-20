using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupsulePropertyTest : MonoBehaviour
{
    private int counter;
    [SerializeField] private int maxCount;
    public int MaxCount { get => maxCount; set => maxCount = value; }
    public int Counter { get => counter; }

    private void AddCount()
    {
        if (maxCount >= counter)
        {
            counter++;
        }
    }
    private void Update()
    {
        AddCount();
        Debug.Log(counter);
    }
}