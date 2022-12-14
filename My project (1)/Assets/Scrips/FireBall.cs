using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] int damage;
    private PlayersFireBall playerFireBoom2;
    private  GameObject fire2;
    // Start is called before the first frame update
    void Start()
    {
        fire2 = GameObject.FindGameObjectWithTag("Player");

        playerFireBoom2 = fire2.GetComponent<PlayersFireBall>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);

    }
    private void OnTriggerEnter(Collider other)
    {
        HealthEnemy enemy = other.GetComponent<HealthEnemy>();
        if (enemy != null)
        {
            enemy.HurtEnemy(damage);
        }
        HealthPlayer player = other.GetComponent<HealthPlayer>();
        if (player != null)
        {
            player.HurtPlayer(damage);
        }
        Vector3 pos = gameObject.transform.position;
        playerFireBoom2.Boom2(pos);
        Destroy(gameObject);
    }

   
}
