using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Projects.Script.PvP
{        

   public class PlayerSlot : Slot
   {
      [SerializeField] private Text textPointAttack;
      public  override  void OnDrop(PointerEventData eventData)
      {
         base.OnDrop(eventData);
         GameObject dropped = eventData.pointerDrag;
         
         dropped.GetComponent<DrapAbleItem>().SetDropOnTeam(false); 
         
         this.DecreaseAttack(eventData);         
      }

      private void DecreaseAttack(PointerEventData eventData)
      {
         GameObject dropped = eventData.pointerDrag;
         if (!dropped.GetComponent<DrapAbleItem>().droppedOnSlotDeck)
         {
            int sumAttack = int.Parse(textPointAttack.text);
            if (sumAttack == 0) return;
            sumAttack -= dropped.GetComponent<Card>().attack;
            textPointAttack.text = sumAttack.ToString();
           dropped.GetComponent<DrapAbleItem>().droppedOnSlotDeck = true;

         }
      }
   }
}
