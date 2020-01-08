using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerWhite : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;

    public int speed = 5;
    private bool WhiteManMoving;
    private Vector2 lastMove;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        WhiteManMoving = false;

        if (Input.GetAxisRaw("HorizontalWhite") > 0.5f || Input.GetAxisRaw("HorizontalWhite") < -0.5f)
        {
            //transform.Translate(new Vector3(Input.GetAxisRaw("HorizontalWhite") * speed * Time.deltaTime, 0f, 0f));
            rb.velocity = new Vector2(Input.GetAxisRaw("HorizontalWhite") * speed, rb.velocity.y);
            WhiteManMoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("HorizontalWhite"), 0f);
        }

        if (Input.GetAxisRaw("VerticalWhite") > 0.5f || Input.GetAxisRaw("VerticalWhite") < -0.5f)
        {
            //transform.Translate(new Vector3(0f, Input.GetAxisRaw("VerticalWhite") * speed * Time.deltaTime, 0f));
            rb.velocity = new Vector2(rb.velocity.x, Input.GetAxisRaw("VerticalWhite") * speed);
            WhiteManMoving = true;
            lastMove = new Vector2(0f, Input.GetAxisRaw("VerticalWhite"));
        }

        if (Input.GetAxisRaw("HorizontalWhite") < 0.5f && Input.GetAxisRaw("HorizontalWhite") > -0.5f)

            rb.velocity = new Vector2(0f, rb.velocity.y);



        if (Input.GetAxisRaw("VerticalWhite") < 0.5f && Input.GetAxisRaw("VerticalWhite") > -0.5f)

            rb.velocity = new Vector2(rb.velocity.x, 0f);



        anim.SetFloat("MoveX", Input.GetAxisRaw("HorizontalWhite"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("VerticalWhite"));
        anim.SetBool("WhiteManMoving", WhiteManMoving);
        anim.SetFloat("LastMoveX", lastMove.x);
        anim.SetFloat("LastMoveY", lastMove.y);

    }
}
