using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SpaceDroppable : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        DragDrop item = eventData.pointerDrag.GetComponent<DragDrop>();

        int count = 0;
        foreach (Transform child in this.transform)
        {
            count++;
        }

        if (item != null && count < 3)
        {
            item.returnParent = this.transform;
        }

    }
}
