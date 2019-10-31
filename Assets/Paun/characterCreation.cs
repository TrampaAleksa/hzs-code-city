using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class characterCreation : MonoBehaviour
{
    [SerializeField]
    private GameObject boyPrefab;
    [SerializeField]
    private GameObject girlPrefab;
	public GameObject camera;
    public Button left, right, jump ;

    void Awake()
    {

        Text text = GameObject.Find("character").GetComponent<Text>();
        if (text.text == "boy")
        {
            GameObject newObject =(GameObject) Instantiate(boyPrefab, this.transform, false);
            AddTriggers(newObject);
          
        } else if (text.text == "girl")
        {
            GameObject newObject = (GameObject) Instantiate(girlPrefab, this.transform, false);
            AddTriggers(newObject);
        }
    }



    public void AddTriggers(GameObject character)
    {
        EventTrigger triggerLeft = left.GetComponent<EventTrigger>();
        EventTrigger.Entry entry1 = new EventTrigger.Entry();
        entry1.eventID = EventTriggerType.PointerDown;
        entry1.callback.AddListener((eventData) =>
        {
            character.GetComponent<PlayerControllerv2>().AllowMovement(true);
        });
        triggerLeft.triggers.Add(entry1);

        EventTrigger triggerLeftStop = left.GetComponent<EventTrigger>();
        EventTrigger.Entry entry2 = new EventTrigger.Entry();
        entry2.eventID = EventTriggerType.PointerUp;
        entry2.callback.AddListener((eventData) =>
        {
            character.GetComponent<PlayerControllerv2>().DontAllowMovement();
        });
        triggerLeftStop.triggers.Add(entry2);

        EventTrigger triggerRight = right.GetComponent<EventTrigger>();
        EventTrigger.Entry entry3 = new EventTrigger.Entry();
        entry3.eventID = EventTriggerType.PointerDown;
        entry3.callback.AddListener((eventData) =>
        {
            character.GetComponent<PlayerControllerv2>().AllowMovement(false);
        });
        triggerRight.triggers.Add(entry3);

        EventTrigger triggerRightStop = right.GetComponent<EventTrigger>();
        EventTrigger.Entry entry4 = new EventTrigger.Entry();
        entry4.eventID = EventTriggerType.PointerUp;
        entry4.callback.AddListener((eventData) =>
        {
            character.GetComponent<PlayerControllerv2>().DontAllowMovement();
        });
        triggerRightStop.triggers.Add(entry4);

        jump.onClick.AddListener(() =>
        {
            character.GetComponent<PlayerControllerv2>().Jump();
        });
    }

}
