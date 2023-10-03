using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Up_Window : MonoBehaviour, IPointerDownHandler
{
    private RectTransform rectTransform;

    //Invoked when the mouse pointer goes down on a UI element.
    public void OnPointerDown(PointerEventData data)
    {
        // Puts the panel to the back as it is now the first UI element to be drawn.
        rectTransform.SetAsFirstSibling();
    }
}
