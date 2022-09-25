using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireForEnemy : MonoBehaviour
{
    public GameObject fireBallPrefab;
    private GameObject fireBall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void FireBallEn()
        {
        fireBall = Instantiate(fireBallPrefab);
        fireBall.transform.position = transform.TransformPoint(Vector3.forward * 2f);
        fireBall.transform.rotation = transform.rotation;
        
    }
}
