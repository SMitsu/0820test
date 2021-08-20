using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kadai7 : MonoBehaviour
{
    public int Count = 0;
    int a = 0;
    int sum = 0;
    private void Start()
    {
        while (sum < Count)
        {
            sum++;
            a += sum;
        }
        Debug.Log(a);

    }
}