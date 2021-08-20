using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereTest : MonoBehaviour
{
    [SerializeField] private CubeTest cubeInstance;
    // Start is called before the first frame update
    public void Start()
    {
        cubeInstance.CubeMethod();
        cubeInstance.ChangeName("sphere");
    }
    public void SphereMethod()
    {
        Debug.Log("TestShereよばれた");
    }
}
