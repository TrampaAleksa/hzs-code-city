using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Battery : MonoBehaviour
{
    public Sprite[] batteries;
    public int batteryIndex = 0;
    public Image currentBattery;

	public int playTimeInSeconds = 10;
	private int timeBetweenDrains;

    void Start(){

		timeBetweenDrains = playTimeInSeconds / batteries.Length;
        StartCoroutine("DrainBattery");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DrainBattery()
    {
        yield return new WaitForSeconds(timeBetweenDrains);
        if(batteryIndex < batteries.Length){
            currentBattery.sprite = batteries[batteryIndex];
            batteryIndex++;
        } else{
			SceneManager.LoadScene(0);
            yield break;
        }
			yield return StartCoroutine(DrainBattery());

			
    }

}
