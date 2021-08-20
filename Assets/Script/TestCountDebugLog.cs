using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCountDebugLog : MonoBehaviour
{
    void Start()
    {
        TestCountLog(5);
    }
    private void TestCountLog(int count)
    {
        Debug.Log("引数は" + count);
    }
}