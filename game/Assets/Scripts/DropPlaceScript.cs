using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropScript : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        CardScr card = eventData.pointerDrag.GetComponent<CardScr>();

        if (card)
            card.DefaultParent = transform;

    }
}
