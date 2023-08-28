using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Projects.Script.PvP
{
    public class TeamSlot : Slot.Slot
    {
        [Header("ButtonFight")]
        [SerializeField] private GameObject buttonFight;
        [Header("tutorialAnimaiton")]
        [SerializeField] private GameObject tutorial;
        
        
        
        public override void OnDrop(PointerEventData eventData)
        {
            base.OnDrop(eventData);
            GameObject dropped = eventData.pointerDrag;
            buttonFight.SetActive(true);
//            tutorial.SetActive(false);
        }
  

    }
}
