using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kadai4 : MonoBehaviour
{
    public List<GameObject> gameObjects;
    // Start is called before the first frame update
    void Start()
    {
        List<int> valueList = new List<int>() { 5, 4, 3, 2, 1 };

        foreach (var value in valueList)
        {
            Debug.Log(value);
        }
    }
}
