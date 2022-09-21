using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorExamples : MonoBehaviour
{
    
    
    [SerializeField] private Transform _vector;

    void Start()
    {
        //https://docs.unity3d.com/ScriptReference/Vector3-magnitude.html
        
        print(_vector.position.magnitude);

    }
    
    
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
