using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameOver : MonoBehaviour
{
    void Start()
    {
        Invoke("changeScene", 5f);
    }
    public  void click()
    {
        Invoke("changeScene", 0.5f);
    }
    void changeScene()
    {
        SceneManager.LoadScene(0);
    }
}
