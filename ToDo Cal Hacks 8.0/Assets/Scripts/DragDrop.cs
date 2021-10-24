using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform returnParent=null;

    public void OnBeginDrag(PointerEventData eventData)
    {
        //Debug.Log("mousedown on object");
        this.GetComponent<CanvasGroup>().blocksRaycasts = false;
        returnParent = this.transform.parent;
        this.transform.SetParent(GameObject.Find("Canvas").transform);
    }

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("Dragging");
        this.transform.position = eventData.position - new Vector2(118, 0);

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //Debug.Log("Let go of drag");
        this.transform.SetParent(returnParent);
        this.GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
