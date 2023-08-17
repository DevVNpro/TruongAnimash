using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Projects.Script.PvP
{
    public class TeamSlot : Slot
    {
        [Header("PointAtack")]
        [SerializeField] private Text textPointAttack;
        [Header("ButtonFight")]
        [SerializeField] private GameObject buttonFight;
        [Header("tutorialAnimaiton")]
        [SerializeField] private GameObject tutorial;
        
        
        
        public override void OnDrop(PointerEventData eventData)
        {
            base.OnDrop(eventData);
            GameObject dropped = eventData.pointerDrag;

            dropped.GetComponent<DrapAbleItem>().SetDropOnDeck(false);
            this.UpAttackTeam(eventData);
            buttonFight.SetActive(true);
            tutorial.SetActive(false);
        }
        private void UpAttackTeam(PointerEventData eventData)
        {
            GameObject dropped = eventData.pointerDrag;
            bool check = dropped.GetComponent<DrapAbleItem>().droppedOnSlotTeam;
            if (!check)
            {
                int sumAttack = int.Parse(textPointAttack.text);
                sumAttack += dropped.GetComponent<Card>().attack;
                textPointAttack.text = sumAttack.ToString();
              dropped.GetComponent<DrapAbleItem>().droppedOnSlotTeam = true;
            }
         
        }

    }
}
