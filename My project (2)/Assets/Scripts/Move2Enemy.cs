using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Move2Enemy : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform endMove;
    private GameObject _end;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        _end = GameObject.FindGameObjectWithTag("EndMove");
        endMove = _end.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveEnemy();
        //IsEnd();
    }

    private void MoveEnemy()
    {
        agent.destination = endMove.position;
    }

    private void IsEnd()
    {
        if (!agent.pathPending)
        {
            Destroy(agent.gameObject);
        }
    }
}
