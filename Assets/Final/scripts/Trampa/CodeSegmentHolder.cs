using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Code Holder", order = 1)]
public class CodeSegmentHolder :ScriptableObject
{
    public CodeSegment[] codeSegments;
}
