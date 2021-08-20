using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMethod : MonoBehaviour
{
    void Start()
    {
        TestDebugLog();
    }
    private void TestDebugLog()
    {
        Debug.Log("TestDebugLogがよばれた");
    }
}
