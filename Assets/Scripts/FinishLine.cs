using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    public ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void FinishGame()
    {
        scoreManager.CalculateFinalScore();
        SceneManager.LoadScene(4);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Triggered!");
        if(collision.gameObject.tag == "Player")
        {
            FinishGame();
        }
    }
}
