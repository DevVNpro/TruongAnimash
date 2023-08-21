using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Projects.Script.PvP
{        

   public class PlayerSlot : Slot.Slot
   {
      public  override  void OnDrop(PointerEventData eventData)
      {
         base.OnDrop(eventData);
         //DoSomething
      }

     
   }
}
