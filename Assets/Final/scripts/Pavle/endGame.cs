﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endGame : MonoBehaviour
{

    bool gameHasEnded = false;

    public  void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            GameOver();
        }

    }

    void GameOver()
    {
        SceneManager.LoadScene(7);
    }

}
