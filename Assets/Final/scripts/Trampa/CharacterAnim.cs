using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    public Animator animator;
	private bool firstJump;
    // Start is called before the first frame update
    void Start()
    {
		firstJump = true;
    }


    public void SetRunningAnimation(bool isMoving)
    {
        animator.SetBool("isRunning", isMoving);
    }
    public void TriggerJumpAnimation()
    {
		if (firstJump)
		{
			animator.SetTrigger("jump");
			firstJump = false;
		}
		else
		{
			animator.SetTrigger("doubleJump");
			firstJump = true;
		}

	}
}
