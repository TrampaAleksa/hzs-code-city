using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class dataEnter : MonoBehaviour
{
    public InputField inputfield;
    public Text text;
    void Update()
    {
        text.text = Random.Range(0, 100).ToString();
    }

    public void insertToTheFile()
    {
        if (inputfield.text != "")
        {
            StreamWriter sw = new StreamWriter("Assets/highscore.txt", true);
            string line = inputfield.text + "$" + text.text + ";";
            sw.Write(line);
            sw.Close();
            SceneManager.LoadScene(4);
        }
    }
 
    public void HZSSite()
    {
        Application.OpenURL("http://hzs.fonis.rs");
    }
}
