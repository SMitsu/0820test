using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTest : MonoBehaviour
{
    public int counter;
    public void BaseMethod()
    {
        Debug.Log("Base!");
        counter = 10;
    }
}