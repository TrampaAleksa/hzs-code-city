using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorUp : MonoBehaviour
{
    public Transform posA;
    public Transform posB;
    public float speed;
    public Transform startPos;

    Vector3 nextPos;

    // Start is called before the first frame update
    void Start()
    {
        nextPos = startPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == posA.position)
        {
            nextPos = posB.position;
            speed = 0;
        }
        if (transform.position == posB.position)
        {
            nextPos = posA.position;
            speed = 0;
        }
        speed = speed + 3;
        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed*Time.deltaTime);
    }

}
