using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "EnemyCar")
        {
            SceneManager.LoadScene("Game Over");
        }
    }

}

