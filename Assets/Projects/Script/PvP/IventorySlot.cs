using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class IventorySlot : MonoBehaviour,IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        DrapAbleItem drapAbleItem = dropped.GetComponent<DrapAbleItem>();
        drapAbleItem.parentAfterDrag = transform;
    }
}
