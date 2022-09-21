using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersFireBall : MonoBehaviour
{
    [SerializeField] private GameObject fireBallPrefab;
    [SerializeField] private GameObject fireBallPrefab2;
    private GameObject fireBall;
    private float count = 0;
    [SerializeField] GameObject boom2;
    private int count2 = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (count2 == 0)
            {
                if (fireBall == null || count >= 0.1f)
                {
                    fireBall = Instantiate(fireBallPrefab) as GameObject;
                    fireBall.transform.position = transform.TransformPoint(Vector3.forward * 1.5f);
                    fireBall.transform.rotation = transform.rotation;
                    count = 0;
                }
                count = count + Time.deltaTime;
            }
            if (count2 == 1)
            {
                if (fireBall == null || count >= 0.2f)
                {
                    fireBall = Instantiate(fireBallPrefab2) as GameObject;
                    fireBall.transform.position = transform.TransformPoint(Vector3.forward * 3f);
                    fireBall.transform.rotation = transform.rotation;
                    count = 0;
                }
                count = count + Time.deltaTime;

            }
        }
    }

    public  void Boom2(Vector3 pos)
    {
        StartCoroutine(FireFire(pos));
    }

        private IEnumerator FireFire(Vector3 pos)

    {
        GameObject boom22 = Instantiate(boom2, pos, Quaternion.identity);
        yield return new WaitForSeconds(1f);
        Destroy(boom22);
    }
     public void CountForFire()
    {
        count2 = 1;
    }


}
