using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseVirtualTest : MonoBehaviour
{
    private void Start()
    {
        TestMethod();
    }
    public virtual void TestMethod()
    {
        Debug.Log("Base Virtual!");
    }
}
