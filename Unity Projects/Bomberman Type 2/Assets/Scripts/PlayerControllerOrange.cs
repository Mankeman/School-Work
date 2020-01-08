using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerOrange : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;

    public int speed =5;
    private bool OrangeManMoving;
    private Vector2 lastMove;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        OrangeManMoving = false;

        if (Input.GetAxisRaw("HorizontalOrange") > 0.5f || Input.GetAxisRaw("HorizontalOrange") < -0.5f)
        {
            //transform.Translate(new Vector3(Input.GetAxisRaw("HorizontalOrange") * speed * Time.deltaTime, 0f, 0f));
            rb.velocity = new Vector2(Input.GetAxisRaw("HorizontalOrange") * speed, rb.velocity.y);
            OrangeManMoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("HorizontalOrange"), 0f);
        }

        if (Input.GetAxisRaw("VerticalOrange") > 0.5f || Input.GetAxisRaw("VerticalOrange") < -0.5f)
        {
            //transform.Translate(new Vector3(0f, Input.GetAxisRaw("VerticalOrange") * speed * Time.deltaTime, 0f));
            rb.velocity = new Vector2(rb.velocity.x, Input.GetAxisRaw("VerticalOrange") * speed);
            OrangeManMoving = true;
            lastMove = new Vector2(0f, Input.GetAxisRaw("VerticalOrange"));
        }

        if (Input.GetAxisRaw("HorizontalOrange") < 0.5f && Input.GetAxisRaw("HorizontalOrange") > -0.5f)

            rb.velocity = new Vector2(0f, rb.velocity.y);



        if (Input.GetAxisRaw("VerticalOrange") < 0.5f && Input.GetAxisRaw("VerticalOrange") > -0.5f)

            rb.velocity = new Vector2(rb.velocity.x, 0f);



        anim.SetFloat("MoveX", Input.GetAxisRaw("HorizontalOrange"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("VerticalOrange"));
        anim.SetBool("OrangeManMoving", OrangeManMoving);
        anim.SetFloat("LastMoveX", lastMove.x);
        anim.SetFloat("LastMoveY", lastMove.y);

    }
}
