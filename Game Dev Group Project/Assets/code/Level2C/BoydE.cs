using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoydE : MonoBehaviour
{

    public float speed = 5f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);

    }

    

}
