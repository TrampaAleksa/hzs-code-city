using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class credits : MonoBehaviour
{
    void Start()
    {
        Invoke("mainMenu", 25f);
    }

    void mainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
