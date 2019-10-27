using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isItPressed : MonoBehaviour
{
    public bool pressed;

     void Start()
    {
        pressed = false;
    }


    public void btnPressed()
    {
        pressed = true;
       
    }
}
