using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class dataEnter : MonoBehaviour
{
    public InputField inputfield;
	private string score;
    public Text text;

	private void Awake()
	{
		score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>().finalScore.ToString();
		print(score);
		text.text = score;
	}


    public void insertToTheFile()
    {
        if (inputfield.text != "")
        {
            StreamWriter sw = new StreamWriter("Assets/highscore.txt", true);
            string line = inputfield.text + "$" + text.text + ";";
            sw.Write(line);
            sw.Close();
            SceneManager.LoadScene(5);
        }
    }
 
    public void HZSSite()
    {
        Application.OpenURL("http://hzs.fonis.rs");
    }
}
