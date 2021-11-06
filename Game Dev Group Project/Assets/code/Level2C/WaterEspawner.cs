using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterEspawner : MonoBehaviour
{

    public GameObject Shark;
    public float maxPos = 13.5313f;
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
            Vector3 EnemyPos = new Vector3(Random.Range(13.5313f, 13.5313f), transform.position.y, transform.position.z);
            Instantiate(Shark, EnemyPos, transform.rotation);
            timer = delayTimer;
        }


    }
}
