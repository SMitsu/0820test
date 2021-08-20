using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kadai3 : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {
        if (this.transform.position.y < -10)
        {
            this.transform.position = Vector3.zero;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}