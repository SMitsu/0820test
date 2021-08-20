using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kadai2 : MonoBehaviour
{
    public int Score = 50;
    private void Start()
    {
        if (Score >= 90)
        {
            Debug.Log("S");
        }
        else if (Score >= 80)
        {
            Debug.Log("A");
        }
        else if (Score >= 70)
        {
            Debug.Log("B");
        }
        else if (Score >= 60)
        {
            Debug.Log("C");
        }
        else
        {
            Debug.Log("D");
        }
    }
}
