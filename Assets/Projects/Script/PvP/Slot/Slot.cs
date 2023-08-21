using UnityEngine;
using UnityEngine.EventSystems;

namespace Projects.Script.PvP.Slot
{
    public class Slot : MonoBehaviour,IDropHandler
    {
        public virtual void OnDrop(PointerEventData eventData)
        {
            GameObject dropped = eventData.pointerDrag;
            DrapAbleItem drapAbleItem = dropped.GetComponent<DrapAbleItem>();
            drapAbleItem.parentAfterDrag =  this.transform;
        }
    }
}
