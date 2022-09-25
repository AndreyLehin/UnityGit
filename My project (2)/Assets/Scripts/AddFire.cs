using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddFire : MonoBehaviour
{
    private PlayersFireBall _fireBall2;
    [SerializeField] GameObject player;
    void Start()
    {
        _fireBall2 = player.GetComponent<PlayersFireBall>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            _fireBall2.CountForFire();
            Destroy(gameObject);

        }
    }
}
