using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyUseTest : MonoBehaviour
{
    [SerializeField] CupsulePropertyTest CupsulePropertyTest;
    private void Start()
    {
        Debug.Log("最大値は" + CupsulePropertyTest.MaxCount);
    }
    private void Update()
    {
        if (CupsulePropertyTest.Counter % 100 == 0)
        {
            Debug.Log("100で割り切れた");
        }
    }
}
