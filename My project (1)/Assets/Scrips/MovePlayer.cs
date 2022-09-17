using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private float _speedMoveX;
    [SerializeField] private float _speedMoveZ;
    private float _speedMove;

    [SerializeField] private float _speedRot;
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
        //if (_charController.isGrounded)
        //{
            deltaX = Input.GetAxis("Horizontal") * _speedMoveX;
            deltaZ = Input.GetAxis("Vertical") * _speedMoveZ;
            movement = new Vector3(deltaX, 0, deltaZ);
        _speedMove = Mathf.Sqrt(_speedMoveX * _speedMoveX + _speedMoveZ * _speedMoveZ);
        //}
        movement = Vector3.ClampMagnitude(movement, _speedMove);
        movement.y = _gravity;
        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        _charController.Move(movement);
        transform.Rotate(0, Input.GetAxis("Mouse X") * _speedRot, 0);


    }

    private void FixedUpdate()
    {
       
       
    }
}
