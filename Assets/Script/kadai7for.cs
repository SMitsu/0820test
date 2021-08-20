using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kadai7for : MonoBehaviour
{
    public int x = 0;
    int a = 0;
    void Start()
    {
        for (int i = 0; i <= x; i++)
        {
            a += i;
        }
        Debug.Log(a);
    }
}