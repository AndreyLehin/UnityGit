using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turel : MonoBehaviour
{
    private float _dist;
    [SerializeField] private float distance;
    [SerializeField] private float time;
    private FireForEnemy fireForEnemy;
    private float count = 0;
    private GameObject _enemy;
    private Transform _trEnemy;
    // Start is called before the first frame update
    void Start()
    {
        _enemy = GameObject.FindGameObjectWithTag("Enemy");
        _trEnemy = _enemy.GetComponent<Transform>();
        fireForEnemy = GetComponent<FireForEnemy>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_enemy != null)
        {
            _dist = Vector3.Distance(_trEnemy.position, transform.position);
        }
        else
        {
            _enemy = GameObject.FindGameObjectWithTag("Enemy");
            _trEnemy = _enemy.GetComponent<Transform>();
            _dist = Vector3.Distance(_trEnemy.position, transform.position);

        }
        if (_dist > distance)
        {

            _enemy = GameObject.FindGameObjectWithTag("Enemy");
            _trEnemy = _enemy.GetComponent<Transform>();
            _dist = Vector3.Distance(_trEnemy.position, transform.position);
        }
        if (_dist < distance)
        {
           count= count + Time.deltaTime;    
                transform.LookAt(_trEnemy.position );

                if (time <= count)
                {
                    fireForEnemy.FireBallEn();
                count = 0;
                }
            
        }

    }
}
