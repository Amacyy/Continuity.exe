using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdspawner : MonoBehaviour
{

    public GameObject Bird;
    public float maxPos = 6.09f;
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
            Vector3 EnemyPos = new Vector3(Random.Range(6.09f, 6.09f), transform.position.y, transform.position.z);
            Instantiate(Bird, EnemyPos, transform.rotation);
            timer = delayTimer;
        }


    }
}
