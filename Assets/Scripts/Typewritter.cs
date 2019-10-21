using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Typewritter : MonoBehaviour
{

    Text txt;
    string[] story;
	public float typeSpeed = 0.075f;


    void Awake()
    {
		CodesQueue codesQueue= new CodesQueue();
        txt = GetComponent<Text>();
        //story = txt.text;
		story = codesQueue.CodesArray;
        txt.text = "";

        // TODO: add optional delay when to start
        StartCoroutine("PlayText");
    }

	void superSpeedTrigger()
	{
		typeSpeed = 0.002f;
	}

    IEnumerator PlayText()
    {
		int i = 0;
		int lineNumber = 0;
		foreach(string line in story)
		{
			if (lineNumber % 3 == 0)
			{
				txt.text = "";
			}
			lineNumber++;
			foreach (char c in line)
			{
				i++;

				if (i == 40)
				{
					superSpeedTrigger();
				}
				txt.text += c;
				yield return new WaitForSeconds(typeSpeed);
			}
			txt.text += "\n";
			yield return new WaitForSeconds(0.002f);
		}
      
    }
}
