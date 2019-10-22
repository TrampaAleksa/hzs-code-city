using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Dropzone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{



    public void OnDrop(PointerEventData eventData)
    {
        //Debug.Log(eventData.pointerDrag.name + "was dropped on" + gameObject.name);
        Draggable componentInDropZone = gameObject.GetComponentInChildren<Draggable>();
        Vector3 position = componentInDropZone.gameObject.transform.position;
        Debug.Log("parent of component in dropzone: " + componentInDropZone.gameObject.transform.name);
        //parent and position of the code in the drop zone
        //Transform dropzoneCodeParent = temp.GetComponent<Draggable>().startingParent;
        //Vector3 dropzoneCodePosition = temp.GetComponent<Draggable>().startingPosition;
        //parent and position of the code that was dropped

        Draggable componentDropped = eventData.pointerDrag.gameObject.GetComponent<Draggable>();
        Vector3 position2 = componentDropped.gameObject.transform.position;

        Debug.Log("parent of component dropped: " + componentDropped.gameObject.transform.name);


         //Transform droppedCodeParent = componentDropped.startingParent;
        // Vector3 droppedCodePosition = componentDropped.startingPosition;
        componentInDropZone.transform.parent = componentDropped.startingParent;
        //componentInDropZone.transform.position = position;
        componentDropped.transform.parent = componentInDropZone.startingParent;
        componentDropped.startingParent = componentDropped.transform.parent;
        componentInDropZone.startingParent = componentInDropZone.transform.parent;

        //componentDropped.transform.position = position2;

        // componentInDropZone.transform.position = droppedCodePosition;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //Debug.Log("OnPointerEnter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
       // Debug.Log("OnPointerExit");
    }
}
