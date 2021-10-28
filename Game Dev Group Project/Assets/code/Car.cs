using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float camDistance = Vector3.Distance(transform.position, Camera.main.transform.position);
        Vector2 bottomCorner = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, camDistance));
        Vector2 topCorner = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, camDistance));

        minY = bottomCorner.y;
        maxY = topCorner.y;

    }

    // Update is called once per frame
    void Update()
    {
        // Get current position
        Vector3 pos = transform.position;


        // vertical contraint
        if (pos.y < minY) pos.y = minY;
        if (pos.y > maxY) pos.y = maxY;

        // Update position
        transform.position = pos;

        MoveCharacter();

    }

    private void MoveCharacter()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.down* speed * Time.deltaTime);
    }

    float speed = 10.0f;
    private float minY;
    private float maxY;
    private float minX;
    private float maxX;
}
