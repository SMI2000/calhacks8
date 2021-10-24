using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Trash : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public Sprite close;
    public Sprite open;
    public GameObject img;

    public void OnPointerEnter(PointerEventData eventData)
    {
        this.GetComponent<Image>().color = new Color32(215, 215, 215, 0);
        img.GetComponent<Image>().sprite = open;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        this.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        img.GetComponent<Image>().sprite = close;
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag.gameObject.CompareTag("Note"))
        {
            Destroy(eventData.pointerDrag.gameObject);
        }

    }
}
