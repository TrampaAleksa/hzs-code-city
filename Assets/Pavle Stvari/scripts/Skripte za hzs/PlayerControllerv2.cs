using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControllerv2 : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed = 2f;
    public float jumpForce = 5f;

    private bool moveLeft;
    private bool dontMove;
    private bool canJump;


    
    public int extraJumps ;
    private int jumpsRemaining; //2

    public Button jumpDugme;
    

     void Start()
    {
        jumpsRemaining = extraJumps;
        rb = GetComponent<Rigidbody2D>();
        dontMove = true;
        
    }

    private void Update()
    {
        //Debug.Log("numberOfjumps" + extraJumps);
       // Debug.Log("jumpsRemaining" + jumpsRemaining);
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
            }else if (!moveLeft)
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
        if (jumpsRemaining >= 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            jumpsRemaining--;
        }
       
      
    }
        

    public void MoveLeft()
    {
        rb.velocity = new Vector2(-speed, rb.velocity.y);
    }

    public void MoveRight()
    {
        rb.velocity = new Vector2(speed , rb.velocity.y);
    }

    public void StopMoving()
    {
        rb.velocity = new Vector2(0f, rb.velocity.y);
    }

    void DetectImput()
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
        else{
            StopMoving();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground" )
        {
            jumpsRemaining=extraJumps;
          
        }
    }

   




}
