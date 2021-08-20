using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestReturn : MonoBehaviour
{
    void Start()
    {
        int retumCount = TestReturnCount(5);
        Debug.Log("ReturnCount:" + retumCount);
    }

    private int TestReturnCount(int count)
    {
        return count + 5;
    }
}
