using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupsuleSerializeFieldTest : MonoBehaviour
{
    private int counter;
    [SerializeField] private int maxCout;

    private void AddCount()
    {
        if(maxCout>=counter)
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
