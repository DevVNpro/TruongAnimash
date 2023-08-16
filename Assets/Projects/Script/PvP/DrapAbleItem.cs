using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Projects.Script.PvP
{
    public class DrapAbleItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
    {
        public Image image;
        [HideInInspector]public Transform parentAfterDrag;
        public bool droppedOnSlotTeam;
        public bool droppedOnSlotDeck;

        private void Awake()
        {
            droppedOnSlotTeam = false;
            droppedOnSlotDeck = true;
        }

        public void OnBeginDrag(PointerEventData eventData)
        {
            parentAfterDrag = transform.parent;
            transform.SetParent(transform.root);
            transform.SetAsLastSibling();
            image.raycastTarget = false;
        }

        public void OnDrag(PointerEventData eventData)
        {
            transform.position = Input.mousePosition;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            transform.SetParent(parentAfterDrag);
            image.raycastTarget = true;
            
        }

        public void SetDropOnTeam(bool check)
        {
            droppedOnSlotTeam = check;
        }

        public void SetDropOnDeck(bool check)
        {
            droppedOnSlotDeck = check;
        }
    }
}
