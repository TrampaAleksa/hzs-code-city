using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    private Text text;
    

    public int score;

    private int timeElapsed;
	public int quizzesSolved;
    public int finalScore;

     void Awake()
    {
        text = GameObject.Find("Score").GetComponentInChildren<Text>();
    }

    // Start is called before the first frame update
    void Start()
    {
       
         DontDestroyOnLoad(gameObject);
       // SceneManager.LoadScene(1);
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

    public void CalculateFinalScore()
    {
        int numberOfProcessors = score;
        int numberOfSuccessfulQuizzes = quizzesSolved;
        int timeRemaining = Convert.ToInt32(120f - Time.timeSinceLevelLoad) ;

        finalScore = ((timeRemaining * 100) + (numberOfProcessors*3*100)) + (numberOfSuccessfulQuizzes * 10 * 100);
        print("final score:" + finalScore);

    }
}
