using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 

public class PlayerControllerv2 : MonoBehaviour
{
    public AudioSource s;

    private PlayerAnimation playerAnimation;
    private Rigidbody2D rb;
    public Transform player;

    public float speed = 2f;
    public float jumpForce = 5f;

    private bool moveLeft;
    private bool dontMove;
    private bool canJump;

    private bool facingRight = true;

    
    public int extraJumps ;
    private int jumpsRemaining; //2

    
    

     void Start()
    {
        //s = GetComponent<AudioSource>();
        playerAnimation= GetComponent<PlayerAnimation>();
        jumpsRemaining = extraJumps;
        rb = GetComponent<Rigidbody2D>();
        dontMove = true;
        
    }

    private void Update()
    {
     
        HandleMoving();
       
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
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
            s.Play();
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            jumpsRemaining--;
        }
        
      
    }
        

    public void MoveLeft()
    {
        if (facingRight == true)
        {
            Flip();
        }
        rb.velocity = new Vector2(-speed, rb.velocity.y);

    }

    public void MoveRight()
    {
        if (facingRight == false)
        {
            Flip();
        }
       
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
        if (collision.gameObject.tag == "ground" || collision.gameObject.tag=="Platform")
        {
            jumpsRemaining =extraJumps;
            if(collision.gameObject.tag == "Platform")
            {
                player.transform.parent = collision.gameObject.transform;
            }
            if (collision.gameObject.tag == "grinder")
            {
                player.transform.parent = collision.gameObject.transform;
            } 
        }
        if (collision.gameObject.tag == "Die")
        {
            FindObjectOfType<endGame>().EndGame();
            //problem,nece se resetuje scena
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform" )
        {
            player.transform.parent = null;
        }
    }






}
