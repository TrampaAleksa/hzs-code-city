using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoyOrGirImage : MonoBehaviour
{
    public Sprite boy;
    public Sprite girl;
    // Start is called before the first frame update
    void Start()
    {

        Text text = GameObject.Find("character").GetComponent<Text>();
        if (text.text == "boy")
        {
            GetComponent<Image>().sprite = boy;
        }
        else if (text.text == "girl")
        {
            GetComponent<Image>().sprite = girl;
        }
        Destroy(text.gameObject);
    }

}
