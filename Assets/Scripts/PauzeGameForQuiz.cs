using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauzeGameForQuiz : MonoBehaviour
{
    public exceptionFollow exceptionFollow;
    public PlayerControllerv2 playerController;
    public TrailRenderer trailRenderer;
    public Battery battery;
	private GameObject player;

	private void Start()
	{
		player  = GameObject.FindGameObjectWithTag("Player");
		playerController = player.GetComponent<PlayerControllerv2>();
		trailRenderer = player.GetComponent<TrailRenderer>();
	}
	public void toggleScripts()
    {
        player.SetActive(!player.activeSelf);
        exceptionFollow.enabled = !exceptionFollow.enabled;
        battery.enabled = !battery.enabled;
    }

}
