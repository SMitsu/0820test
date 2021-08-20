using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupsuleTest : MonoBehaviour
{
    private int counter;
    private void AddCount()
    {
        counter++;
    }
    private void Update()
    {
        AddCount();
        Debug.Log(counter);
    }
}
