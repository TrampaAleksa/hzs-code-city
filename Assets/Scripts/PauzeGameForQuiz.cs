using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauzeGameForQuiz : MonoBehaviour
{
    public exceptionFollow exceptionFollow;
    public PlayerControllerv2 playerController;
    public TrailRenderer trailRenderer;
    public Battery battery;
    public GameObject player;


    public void toggleScripts()
    {

        player.SetActive(!player.activeSelf);
        exceptionFollow.enabled = !exceptionFollow.enabled;
        battery.enabled = !battery.enabled;
    }

}
