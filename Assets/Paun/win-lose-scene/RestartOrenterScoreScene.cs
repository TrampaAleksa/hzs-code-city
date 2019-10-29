using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOrenterScoreScene : MonoBehaviour
{
    public int sceneToLoad;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadGivenScene", 3);
    }

    public void LoadGivenScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }


}
