using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestWhile2 : MonoBehaviour
{
    public int targetCount = 1;
    private void Start()
    {
        while (targetCount < 10)
        {
            if (targetCount == 5)
            {
                targetCount++;
                continue;
            }
            Debug.Log("targetCount :" + targetCount);
            targetCount++;
        }
    }
}
