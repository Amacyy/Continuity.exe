using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBoat : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() { }
    public void FixedUpdate()
    {
            MoveCharacter();
    }
    public void MoveCharacter()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            animator.SetBool("jump", true);
        else
            animator.SetBool("jump", false);
        if (Input.GetKey(KeyCode.DownArrow))
            animator.SetBool("slide", true);
        else
            animator.SetBool("slide", false);
    }
}

