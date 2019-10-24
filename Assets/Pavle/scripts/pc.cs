using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pc : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (FindObjectOfType<ScoreManager>().score<4)
            {
                SceneManager.LoadScene("NotEnaughCPUS");
            }
            else
            {
                SceneManager.LoadScene("GG");
            }
        }
    }

}

