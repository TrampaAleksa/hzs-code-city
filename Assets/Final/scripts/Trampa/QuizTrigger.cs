using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizTrigger : MonoBehaviour
{
    public CodeController quizController;
    public PauzeGameForQuiz pauzeGame;

    private bool firstTrigger = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (firstTrigger)
            {
                pauzeGame.toggleScripts();
                quizController.TriggerQuiz();
                firstTrigger = false;
            }
        }
      
        
    }
}
