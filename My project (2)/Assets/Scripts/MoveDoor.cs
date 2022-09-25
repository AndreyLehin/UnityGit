using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDoor : MonoBehaviour
{
    [SerializeField] private int doorMoveSpeed;
    [SerializeField] private float doorDistanceMove;
    private bool doorMoveOpen = false;
    private bool doorMoveClose = false;
    [SerializeField] private float  count = 0;
    float posZ;
    float posZ2;
    float speedLeft;
    
    // Start is called before the first frame update
    void Start()
    {
        posZ = transform.position.z;
        posZ2 = posZ - doorDistanceMove;
        speedLeft = -doorMoveSpeed;
        Debug.Log(posZ);
    }

    // Update is called once per frame
    void Update()
    {
        if (doorMoveOpen)
        {
            if (transform.position.z > posZ2)
            {
                D_M_Open();
            }
            if (transform.position.z <= posZ2)
            {
                doorMoveOpen = false;
            }
        }
        if (doorMoveClose & !doorMoveOpen)
        {
                D_M_Close();

            if (transform.position.z >= posZ)
            {
                doorMoveClose = false;
            }
        }
    }
   public void OpenDoor()
    {
        if (!doorMoveClose)
        {
            doorMoveOpen = true;

        }

    }
    public void CloseDoor()
    {
            doorMoveClose = true;
    }

    public void StayDoor()
    {
        doorMoveClose = false ;
        doorMoveOpen = true ;
    }
    private void D_M_Open()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * doorMoveSpeed);
    }

    private void D_M_Close()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speedLeft);
    }
}
