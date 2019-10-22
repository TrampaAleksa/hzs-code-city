using UnityEngine;
using UnityEngine.SceneManagement;

public class resetGame : MonoBehaviour
{
    public void EndGame()
    {
        SceneManager.LoadScene("YouDied");
    }

}
