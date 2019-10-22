using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text text;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void ChangeScore(int cpuValue)
    {

        score += cpuValue;
        text.text = score.ToString();
    }

    public int scoreCounter()
    {
        return score;
    }

     void Update()
    {
        scoreCounter();
    }
}
