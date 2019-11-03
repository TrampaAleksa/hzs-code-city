using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class settings : MonoBehaviour
{
    public Slider slide;
    public Toggle toggle;
    public Dropdown dropdown;
    public AudioMixer audioMixer;
    
    public void SetVolume(float volume) {
        audioMixer.SetFloat("volume", volume);
        PlayerPrefs.SetFloat("slider", volume);
        PlayerPrefs.Save();
    }
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
        PlayerPrefs.SetInt("dropdown", qualityIndex);
        PlayerPrefs.Save();
    }

    public void Return()
    {   
        SceneManager.LoadScene(0);
    }
    public void SoundOnOff(bool sound) {
        AudioListener.pause = !sound;
        if (sound == true)
        {
            PlayerPrefs.SetInt("toggle", 1);
            PlayerPrefs.Save();
        }
        else if (sound == false)
        {
            PlayerPrefs.SetInt("toggle", 0);
            PlayerPrefs.Save();
        }
        
    }
    void Awake() {
        slide.value = PlayerPrefs.GetFloat("slider");
        int ukljucen = PlayerPrefs.GetInt("toggle");
        if (ukljucen == 1)
        {
            toggle.isOn = true;
        }
        else if (ukljucen == 0)
        {
         
            toggle.isOn = false;
        }
        dropdown.value = PlayerPrefs.GetInt("dropdown");
       
    }

   

}
