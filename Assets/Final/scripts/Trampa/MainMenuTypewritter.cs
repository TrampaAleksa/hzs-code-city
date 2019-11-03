using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuTypewritter : MonoBehaviour
{

	Text txt;
	string story;
	public float typeSpeed;
	public Image logo;
	// Start is called before the first frame update
	void Start()
	{
		txt = GetComponentInChildren<Text>();
		story = txt.text;
		txt.text = "";
		StartCoroutine("PlayText");

	}

    // Update is called once per frame
    void Update()
    {
	}

	IEnumerator PlayText()
	{
		
			foreach (var c in story)
			{
				txt.text += c;
				yield return new WaitForSeconds(typeSpeed);
			}
		logo.gameObject.SetActive(true);
	}
}
