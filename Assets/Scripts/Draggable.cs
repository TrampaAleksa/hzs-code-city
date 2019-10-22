using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public RectTransform panelRectTransform;
    public Transform startingParent = null;
    public Transform startingPosition;

    public void Start()
    {
        startingPosition = this.transform;
        startingParent = this.transform.parent;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        startingPosition = this.transform;
        startingParent = this.transform.parent;
        this.transform.parent = this.transform.root;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        //Debug.Log("Begun dragging");
    }

    public void OnDrag(PointerEventData eventData)
    {
       // Debug.Log("dragging");

        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //Debug.Log("Ended dragging");
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        /*panelRectTransform.anchorMin = new Vector2(0, 0);
        panelRectTransform.anchorMax = new Vector2(1, 1);
        panelRectTransform.pivot = new Vector2(0.5f, 0.5f);*/
        // this.transform.parent = startingParent;
         //this.transform.position = startingPosition;
    }
}
