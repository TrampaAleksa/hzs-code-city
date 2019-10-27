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

        transform.position =new Vector3(transform.position.x, eventData.position.y,transform.position.z);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //Debug.Log("Ended dragging");
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    
    }
}
