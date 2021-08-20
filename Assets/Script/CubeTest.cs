using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTest : MonoBehaviour
{
    [SerializeField] private SphereTest sphereInstance;

    private void Start()
    {
        sphereInstance.SphereMethod();
    }
    public void CubeMethod()
    {
        Debug.Log("TestCubeがよばれた");
    }

    public void ChangeName(string name)
    {
        this.gameObject.name = name + "cube";
    }
}