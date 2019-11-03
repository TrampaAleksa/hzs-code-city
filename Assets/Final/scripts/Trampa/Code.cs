using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
    public string[] code;
    public int orderNumber;

    public Code(string[] code, int orderNumber)
    {
        this.code = code;
        this.orderNumber = orderNumber;
    }
}
