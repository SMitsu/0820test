using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFor : MonoBehaviour
{
    private void Start()
    {
        for(int i = 0; i < 5; i++)
        {
            Debug.Log("index:" + i);
        }
    }
}
