using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallMovement : MonoBehaviour
{

    public Transform posStart;
    public Transform posFinish;
    public float wallSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = posStart.position;
    }

    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(posStart.position,posFinish.position,wallSpeed*Time.fixedDeltaTime);
    }
}
