﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainMenu : MonoBehaviour
{
    public void startGame() {
        SceneManager.LoadScene(1);
    }
    public void Settings() {
        SceneManager.LoadScene(2);
    }
    public void Credits() {
        SceneManager.LoadScene(3);
    }
    public void Exit() {
        Application.Quit();
    }

}