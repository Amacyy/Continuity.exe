using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChuteE : MonoBehaviour
{

    public float speed = 5f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime);

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "EnemyCar")
            Destroy(gameObject);
    }

}
