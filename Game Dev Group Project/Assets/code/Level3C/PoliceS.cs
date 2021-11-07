using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceS : MonoBehaviour
{

    public GameObject police;
    public float maxPos = 2.75f;
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
            Vector3 EnemyPos = new Vector3(Random.Range(2.75f, -2.75f), transform.position.y, transform.position.z);
            Instantiate(police, EnemyPos, transform.rotation);
            timer = delayTimer;
        }


    }
}
