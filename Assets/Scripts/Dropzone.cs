using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Dropzone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{



    public void OnDrop(PointerEventData eventData)
    {
        Draggable componentInDropZone = gameObject.GetComponentInChildren<Draggable>();
       

        Draggable componentDropped = eventData.pointerDrag.gameObject.GetComponent<Draggable>();
        Vector3 position2 = componentDropped.gameObject.transform.position;


        if(componentInDropZone == null)
        {
            componentDropped.transform.parent = componentDropped.startingParent;
            return;
        }
        componentInDropZone.transform.parent = componentDropped.startingParent;
        componentDropped.transform.parent = componentInDropZone.startingParent;

        componentDropped.startingParent = componentDropped.transform.parent;
        componentInDropZone.startingParent = componentInDropZone.transform.parent;


    }



    public void OnPointerEnter(PointerEventData eventData)
    {
    }

    public void OnPointerExit(PointerEventData eventData)
    {
    }
}
