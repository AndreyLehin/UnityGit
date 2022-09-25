using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCrateManyEnemy : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float time;
    private GameObject _enemy;
    private float count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (count >= time*100)
        {
            _enemy = Instantiate(enemyPrefab) as GameObject;
            _enemy.transform.position = transform.TransformPoint(Vector3.forward*1.5f);
            count = 0;
        }
        count = (count + 1f);
    }
}
