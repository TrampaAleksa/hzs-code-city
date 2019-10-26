using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battery : MonoBehaviour
{
    public Sprite[] batteries;
    public int batteryIndex = 0;
    public Image currentBattery;

    void Start(){

        StartCoroutine("DrainBattery");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DrainBattery()
    {
        yield return new WaitForSeconds(1);
        print(batteries.Length);
        if(batteryIndex < batteries.Length){
            currentBattery.sprite = batteries[batteryIndex];
            batteryIndex++;
        } else{
            yield break;
        }
			yield return StartCoroutine(DrainBattery());

			
    }

}
