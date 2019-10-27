using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizTrigger : MonoBehaviour
{
    public CodeController quizController;
    public PauzeGameForQuiz pauzeGame;

    private bool triggeredOnce = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!triggeredOnce)
        {
            pauzeGame.toggleScripts();
            quizController.TriggerQuiz();
            triggeredOnce = true;
            print("triggered!");
        }
        
    }
}
