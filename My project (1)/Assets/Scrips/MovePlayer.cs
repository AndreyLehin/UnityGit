using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private float _speedMoveX;
    [SerializeField] private float _speedMoveZ;
    private float deltaX;
    private float deltaZ;
    private float _gravity = -9.8f;
    private CharacterController _charController;
    private Vector3 movement = Vector3.zero;


    // Start is called before the first frame update
    void Start()
    {
        _charController = GetComponent<CharacterController>();

    }
    
    // Update is called once per frame
    void Update()
    {
            deltaX = Input.GetAxis("Horizontal") * _speedMoveX;
            deltaZ = Input.GetAxis("Vertical") * _speedMoveZ;
            movement = new Vector3(0, 0, deltaZ);
       
        movement.y = _gravity;
        
        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        _charController.Move(movement);
        transform.Rotate(0, deltaX, 0);


    }

}
