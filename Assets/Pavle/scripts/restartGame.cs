using UnityEngine;
using UnityEngine.SceneManagement;

public class restartGame : MonoBehaviour
{
    public void playAgain()
    {
        SceneManager.LoadScene("Game");
    }

    public void backToMenu()
    {
        SceneManager.LoadScene("Menu");

    }
    
}
