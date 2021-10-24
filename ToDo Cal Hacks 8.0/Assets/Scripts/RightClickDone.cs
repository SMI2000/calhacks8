using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RightClickDone : MonoBehaviour, IPointerClickHandler
{
    Color32 todo = new Color32(255, 231, 138, 255);
    Color32 done = new Color32(138, 255, 146, 255);
    bool rightclick = false;

    public void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            rightclick = true;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (rightclick)
        {
            Debug.Log("satisfied");
            if (this.GetComponent<Image>().color == todo)
            {
                this.GetComponent<Image>().color = done;
            }
            else
            {
                this.GetComponent<Image>().color = todo;
            }

            rightclick = false;
        }
    }
}
