using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    Transform startingParent = null;
    Vector3 startingPosition;

    public void OnBeginDrag(PointerEventData eventData)
    {
        startingPosition = this.transform.position;
        startingParent = this.transform.parent;
        this.transform.parent = this.transform.root;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        Debug.Log("Begun dragging");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("dragging");

        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("Ended dragging");
        this.transform.parent = startingParent;
        this.transform.position = startingPosition;
    }
}
