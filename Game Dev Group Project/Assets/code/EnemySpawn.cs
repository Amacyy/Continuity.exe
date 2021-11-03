using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    public GameObject Enemy;
    public float maxPos = 4.5f;
    public float delayTimer = 1f;
    float timer;

    void Start()
    {
        timer = delayTimer;
    }

    // Update is called once per frame
    void Update()
    {

        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Vector3 EnemyPos = new Vector3(transform.position.x, Random.Range(-4.5f, 4.5f), transform.position.z);
            Instantiate(Enemy, EnemyPos, transform.rotation);
            timer = delayTimer;
        }

        
    }
}
