using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodesQueue 
{
	protected string[] codesArray = {
			"i++",
			"Hello World!",
			"return 0;",
			"i++",
			"Hello World!",
			"return 0;",
			"i++",
			"Hello World!",
			"return 0;",
			"i++",
			"Hello World!",
			"return 0;",
			"i++",
			"Hello World!",
			"return 0;",
			"i++",
			"Hello World!",
			"return 1;"
			};
	protected string[] temporaryCode = {
		"answer 1;",
		"answer2;",
		"answer3;"
	};

	public string[] CodesArray { get => codesArray; set => codesArray = value; }

	public CodesQueue()
	{
		
	}
}
