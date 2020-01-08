using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerBlack : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;

    public int speed = 5;
    private bool BlackManMoving;
    private Vector2 lastMove;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        BlackManMoving = false;

        if (Input.GetAxisRaw("HorizontalBlack") > 0.5f || Input.GetAxisRaw("HorizontalBlack") < -0.5f)
        {
            //transform.Translate(new Vector3(Input.GetAxisRaw("HorizontalBlack") * speed * Time.deltaTime, 0f, 0f));
            rb.velocity = new Vector2(Input.GetAxisRaw("HorizontalBlack") * speed, rb.velocity.y);
            BlackManMoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("HorizontalBlack"), 0f);
        }

        if (Input.GetAxisRaw("VerticalBlack") > 0.5f || Input.GetAxisRaw("VerticalBlack") < -0.5f)
        {
            //transform.Translate(new Vector3(0f, Input.GetAxisRaw("VerticalBlack") * speed * Time.deltaTime, 0f));
            rb.velocity = new Vector2(rb.velocity.x, Input.GetAxisRaw("VerticalBlack") * speed);
            BlackManMoving = true;
            lastMove = new Vector2(0f, Input.GetAxisRaw("VerticalBlack"));
        }

        if (Input.GetAxisRaw("HorizontalBlack") < 0.5f && Input.GetAxisRaw("HorizontalBlack") > -0.5f)

            rb.velocity = new Vector2(0f, rb.velocity.y);



        if (Input.GetAxisRaw("VerticalBlack") < 0.5f && Input.GetAxisRaw("VerticalBlack") > -0.5f)

            rb.velocity = new Vector2(rb.velocity.x, 0f);



        anim.SetFloat("MoveX", Input.GetAxisRaw("HorizontalBlack"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("VerticalBlack"));
        anim.SetBool("BlackManMoving", BlackManMoving);
        anim.SetFloat("LastMoveX", lastMove.x);
        anim.SetFloat("LastMoveY", lastMove.y);

    }
}
