using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTest : MonoBehaviour
{
    public int caseSwitch = 1;
    private void Start()
    {
        switch (caseSwitch)
        {
            case 1:
                Debug.Log("Case 1");
                break;
            case 2:
                Debug.Log("Case 2");
                break;
            default:
                Debug.Log("Default case");
                break;
        }
    }
}
