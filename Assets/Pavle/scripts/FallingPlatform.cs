using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    bool isFalling = false;
    float downSpeed = 0;
    public Transform endPos;

     public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("igrac pipnuo padajucu");
            isFalling = true;
            
        }
    }

     void Update()
    {
        if (isFalling)
        {
            downSpeed =downSpeed+0.01f;
            transform.position = Vector3.MoveTowards(transform.position,endPos.position,downSpeed);
        }
    }
}
