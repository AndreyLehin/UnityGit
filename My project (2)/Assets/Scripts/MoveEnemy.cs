using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    [SerializeField] private float _speedMove;
    [SerializeField] private float _angle;
    private Transform _target;
    private float count = 0;
    [SerializeField] float obstacleRange;
    private int q;
    [SerializeField] private float distance;
    private int count2 = 0;
    private float _dist;
    private float time = 1;
    private GameObject player;
    private FireForEnemy fireForEnemy;
    private int e;

    // Start is called before the first frame update
    void Start()
    {
        q = Random.Range(1, 4);
        time = time * q;
        player = GameObject.FindGameObjectWithTag("Player");
         _target = player.GetComponent<Transform>();
        fireForEnemy = GetComponent<FireForEnemy>();

    }

    // Update is called once per frame
    void Update()
    {
        
       // if (_target & count2 <=0)
        //{
            _dist = Vector3.Distance(_target.position, transform.position);
        // }
       // if (_dist > distance)
       // {
        transform.Translate(Vector3.forward * Time.deltaTime * _speedMove);

      //  }
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.SphereCast(ray, 0.45f, out hit))
        {
            if (hit.distance < obstacleRange)
            {
                transform.Rotate(0, _angle, 0);
                transform.Translate(Vector3.forward * Time.deltaTime * _speedMove);

                count2 = 200;
            }
        }
        
        if (_dist < distance)
        {
            if (count2 <= 0)
            {
                transform.LookAt(_target.position);
                transform.Translate(Vector3.forward * Time.deltaTime * _speedMove);

                e = Random.Range(0, 100);
                if (e == 1)
                {
                    fireForEnemy.FireBallEn();

                }
            }
        }
        else if (count >= time)
        {
            int r = Random.Range(-120, 120);
            transform.Rotate(0, r, 0);
            count = 0;
            q = Random.Range(1, 8);
            time = 1;
            time = time * q;
        }
        count += Time.deltaTime;
        if (count2 > 0)
        {
            count2--;
            
        }
    }
}

          
