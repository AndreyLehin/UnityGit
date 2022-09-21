using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorScriptExample : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Transform target;
    [SerializeField] private Transform target2;

    [SerializeField] private float speed = 1;
    
    void Start()
    {
        //Quaternion rotation = transform.rotation;
        //Vector3 vector3 = transform.eulerAngles;
//
        //Vector3 relativePos = target.position - transform.position;
        //Quaternion newRotation = Quaternion.LookRotation(relativePos);
        //transform.rotation = newRotation;
        
        //Transform.LookAt(target,Vector3.up);
    }

    // Update is called once per frame
    void Update()
    {
        //float distanceToTarget = Vector3.Distance(transform.position, target.position);
        //Debug.Log(distanceToTarget);

        //transform.position += new Vector3(Time.deltaTime * speed, 0, 0);
        
        //0.02
        //transform.Translate(Vector3.forward*Time.deltaTime,Camera.main.transform);
        
        
        transform.position = Vector3.MoveTowards(transform.position,target.position,speed*Time.deltaTime);
        
        //Quaternion rotation = transform.rotation;
        //Vector3 vector3 = transform.eulerAngles;
//
        //Vector3 relativePos = target.position - transform.position;
        //Quaternion newRotation = Quaternion.LookRotation(relativePos);
        //transform.rotation = newRotation;

        //float angle = Quaternion.Angle(transform.rotation, target.rotation);
        //Debug.Log(angle);
        
        
        //transform.rotation = Quaternion.Slerp(target.rotation,target2.rotation,Time.time);
        
        
        //transform.Rotate(Vector3.up,10);
        
        //transform.RotateAround(target.position,Vector3.right,5*Time.deltaTime);
        
        
        
    }
}
