using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class testMouse : EventTrigger
{
    public override void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("mouse down");
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("mouse up");
    }
}
