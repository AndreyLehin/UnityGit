using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] private GameObject boom1;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void HurtPlayer(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            DeathOfPlayer();
        }
    }

    public void NewHealth(int newHealth)
    {
        health = newHealth;
    }
    public void DeathOfPlayer()
    {
        NewHealth(20);

    }
}
