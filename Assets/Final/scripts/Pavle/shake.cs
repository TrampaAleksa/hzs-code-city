using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shake : MonoBehaviour
{
    public Transform posA;
    public Transform posB;
    public float speed;
    public Transform startPos;
    public Transform objThatShakes;

    Vector3 nextPos;

    // Start is called before the first frame update
    void Start()
    {
        nextPos = startPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (objThatShakes.transform.position == posA.position)
        {
            nextPos = posB.position;
        }
        if (objThatShakes.transform.position == posB.position)
        {
            nextPos = posA.position;
        }

        objThatShakes.transform.position = Vector3.MoveTowards(objThatShakes.transform.position, nextPos, speed);
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawLine(posA.position, posB.position);
    }
}
