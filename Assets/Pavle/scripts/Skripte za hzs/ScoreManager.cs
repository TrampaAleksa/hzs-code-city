using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text text;
    public int score;
    private int timeElapsed;
	public int quizzesSolved;
    public float finalScore;

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
        float timeRemaining = 120f - Time.time;

        finalScore = ((timeRemaining * 100f) + (numberOfProcessors*3*100f)) + (numberOfSuccessfulQuizzes * 10 * 100f);
        print("final score:" + finalScore);

    }
}
