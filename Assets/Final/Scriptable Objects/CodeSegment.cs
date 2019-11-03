using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Code Segment", order = 1)]
public class CodeSegment : ScriptableObject
{
    public string[] codeLines;
    public int orderNumber;

    public string getCode()
    {
        string code = "";
        foreach (string codeLine in codeLines)
        {
            code += codeLine + "\n";
        }
        return code;
    }
}
