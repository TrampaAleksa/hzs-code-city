using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Typewritter : MonoBehaviour
{

    Text txt;
    string[] story;
	public float typeSpeed;
	public int numOfLines;
    public CodeController segments;
    public PauzeGameForQuiz unpauzeGame;



    void OnEnable()
    {
        print("i AM AWAKE");
		story = new string[30];
        story = segments.GetInitialCode();
        txt = GetComponentInChildren<Text>();
        txt.text = "";
        StartCoroutine("PlayText");
    }


    IEnumerator PlayText()
    {
		int lineNumber = 0;
		foreach(string line in story)
		{
			if (lineNumber % numOfLines == 0)
			{
				txt.text = "";
			}
			lineNumber++;
			foreach (char c in line)
			{
                txt.text += c;
				yield return new WaitForSeconds(typeSpeed);
			}
			txt.text += "\n";
			yield return new WaitForSeconds(0.002f);
		}
        yield return new WaitForSeconds(1);
        unpauzeGame.toggleScripts();
        gameObject.SetActive(!gameObject.activeSelf);
        yield break;
    }
}
