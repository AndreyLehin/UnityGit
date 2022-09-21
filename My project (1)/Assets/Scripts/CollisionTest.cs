using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Object collision Enter");
    }

    private void OnCollisionStay(Collision collisionInfo)
    {
        Debug.Log("Object collision Stay");
    }

    private void OnCollisionExit(Collision other)
    {
        Debug.Log("Object collision Exit");
    }
}
