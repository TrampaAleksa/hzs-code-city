using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    private float speed = 10f;
    private float height = 20f;

    private bool moveLeft;
    private bool dontMove;
    private bool canJump=true;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dontMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        HandleMoving();

    }

    void HandleMoving()
    {
        if (dontMove)
        {
            StopMoving();
        }
        else
        {
            if (moveLeft)
            {
                MoveLeft();
            }
            else if (!moveLeft)
            {
                MoveRight();
            }
        }
    }
    public void AllowMovement(bool movement)
    {
        dontMove = false;
        moveLeft = movement;
    }
    public void DontAllowMovement()
    {
        dontMove = true;
    }
    public void Jump()
    {
       if(canJump==true)
       {
            rb.velocity = new Vector2(rb.velocity.x, height);
            
        }
    }
    public void MoveLeft()
    {
        rb.velocity = new Vector2(-speed, rb.velocity.y);
    }
    public void MoveRight()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }
    public void StopMoving()
    {
        rb.velocity = new Vector2(0f, rb.velocity.y);
    }
    void DetectInput()
    {
        float x = Input.GetAxisRaw("Horizontal");
        if (x > 0)
        {
            MoveRight();
        }
        else if (x < 0)
        {
            MoveLeft();
        }
        else
        {
            StopMoving();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            canJump = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "ground")
        {
            canJump = false;
        }
    }
}
