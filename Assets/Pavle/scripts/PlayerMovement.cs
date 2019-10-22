using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    float horizontalMove = 0f;

    public float runSpeed = 40f;

    bool jump = false;

    public int extraJumps;


    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal")*runSpeed;

        if (jump == false)
        {
            extraJumps=2;
        }

        if (Input.GetButtonDown("Jump") && extraJumps>0)
        {
            jump = true;
            extraJumps--;
        }
    }

     void FixedUpdate()
    {
        controller.Move(horizontalMove*Time.fixedDeltaTime,false,jump);
        jump = false;
    }
}
