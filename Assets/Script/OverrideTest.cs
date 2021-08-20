using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverrideTest : BaseVirtualTest
{
    public override void TestMethod()
    {
        base.TestMethod();
        Debug.Log("Override!!");
    }
}
