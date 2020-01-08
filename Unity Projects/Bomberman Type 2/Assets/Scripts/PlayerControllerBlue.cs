using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerBlue : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;

    public int speed = 5;
    private bool BlueManMoving;
    private Vector2 lastMove;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        BlueManMoving = false;

        if (Input.GetAxisRaw("HorizontalBlue") > 0.5f || Input.GetAxisRaw("HorizontalBlue") < -0.5f)
        {
            //transform.Translate(new Vector3(Input.GetAxisRaw("HorizontalBlue") * speed * Time.deltaTime, 0f, 0f));
            rb.velocity = new Vector2(Input.GetAxisRaw("HorizontalBlue") * speed, rb.velocity.y);
            BlueManMoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("HorizontalBlue"), 0f);
        }

        if (Input.GetAxisRaw("VerticalBlue") > 0.5f || Input.GetAxisRaw("VerticalBlue") < -0.5f)
        {
            //transform.Translate(new Vector3(0f, Input.GetAxisRaw("VerticalBlue") * speed * Time.deltaTime, 0f));
            rb.velocity = new Vector2(rb.velocity.x, Input.GetAxisRaw("VerticalBlue") * speed);
            BlueManMoving = true;
            lastMove = new Vector2(0f, Input.GetAxisRaw("VerticalBlue"));
        }

        if (Input.GetAxisRaw("HorizontalBlue") < 0.5f && Input.GetAxisRaw("HorizontalBlue") > -0.5f)

            rb.velocity = new Vector2(0f, rb.velocity.y);



        if (Input.GetAxisRaw("VerticalBlue") < 0.5f && Input.GetAxisRaw("VerticalBlue") > -0.5f)

            rb.velocity = new Vector2(rb.velocity.x, 0f);



        anim.SetFloat("MoveX", Input.GetAxisRaw("HorizontalBlue"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("VerticalBlue"));
        anim.SetBool("BlueManMoving", BlueManMoving);
        anim.SetFloat("LastMoveX", lastMove.x);
        anim.SetFloat("LastMoveY", lastMove.y);

    }
}
