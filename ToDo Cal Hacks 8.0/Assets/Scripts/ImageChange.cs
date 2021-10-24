using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ImageChange : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Sprite close;
    public Sprite open;

    public void OnPointerEnter(PointerEventData eventData)
    {
        this.GetComponent<Image>().sprite = open;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        this.GetComponent<Image>().sprite = close;
    }
}
