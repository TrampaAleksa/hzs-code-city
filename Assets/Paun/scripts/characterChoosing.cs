using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class characterChoosing : MonoBehaviour
{
    public Toggle female;
    public Toggle male;
    public GameObject go;

    public void pictureGirlClick()
    {
        female.isOn = !female.isOn;
        male.isOn = false;
        //male.enabled = false;
        go.GetComponent<Text>().text = "girl";
    }

    public void pictureBoyClick()
    {
        male.isOn = !male.isOn;
        female.isOn = false;
        go.GetComponent<Text>().text = "boy";
    }

    public void girl(bool checkGirl)
    {
        female.enabled = !checkGirl;
        male.isOn = !checkGirl;
        male.enabled = checkGirl;
        go.GetComponent<Text>().text = "girl";
    }

    public void boy(bool checkBoy)
    {
        male.enabled = !checkBoy;
        female.isOn = !checkBoy;
        female.enabled = checkBoy;
        go.GetComponent<Text>().text = "boy";
    }
    public void Apply()
    {
       
        if (female.isOn != male.isOn) {
            DontDestroyOnLoad(go);
            SceneManager.LoadScene(1);
    }
    }
}
