using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoyOrGirImage : MonoBehaviour
{
    public Sprite boy;
    public Sprite girl;
    private string text;
    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.Find("character").GetComponent<Text>().text;
        if (text == "boy")
        {
            GetComponent<Image>().sprite = boy;
        }
        else if (text == "girl")
        {
            GetComponent<Image>().sprite = girl;
        }
    }

}
