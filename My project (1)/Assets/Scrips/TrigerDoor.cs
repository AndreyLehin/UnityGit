using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerDoor : MonoBehaviour
{
    [SerializeField] private GameObject _door;
    private MoveDoor door;

    // Start is called before the first frame update
    void Start()
    {
        door = _door.GetComponent<MoveDoor>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            door.OpenDoor();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            door.CloseDoor();
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            door.StayDoor();
        }
    }
}
