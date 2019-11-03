using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodesQueue 
{
    public CodeSegment[] codeSegments;
    public CodeSegment[,] allCodeSegments;
   
	protected string[] codesArray = {
			"int i=0;",
			"for(i=0; i++; i<3){",
			"Console.WriteLine(i);",
			"}",
			"Console.WriteLine(++i);",
			};
	protected string[] temporaryCode = {
		"answer 1;",
		"answer2;",
		"answer3;"
	};

	public string[] CodesArray { get => codesArray; set => codesArray = value; }
	public string[] TemporaryCode { get => temporaryCode; set => temporaryCode = value; }

	public CodesQueue()
	{
	}

    
}
