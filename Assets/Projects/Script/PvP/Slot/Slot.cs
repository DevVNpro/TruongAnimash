using UnityEngine;
using UnityEngine.EventSystems;

namespace Projects.Script.PvP.Slot
{
    public class Slot : MonoBehaviour,IDropHandler
    {
        public virtual void OnDrop(PointerEventData eventData)
        {
            /*GameObject dropped = eventData.pointerDrag;
            DrapAbleItem drapAbleItem = dropped.GetComponent<DrapAbleItem>();
            drapAbleItem.parentAfterDrag =  this.transform;*/
            if (eventData.pointerEnter.GetComponentInChildren<Card>() != null)
            {
               Debug.Log("Vitri da co the bai");
            }
            // Nếu chưa có thẻ bài, đặt thẻ bài vào slot mới
            else if(eventData.pointerEnter.GetComponent<Slot>())
            {
                // Mã để đặt thẻ bài vào slot mới
                GameObject dropped = eventData.pointerDrag;
                DrapAbleItem drapAbleItem = dropped.GetComponent<DrapAbleItem>();
                drapAbleItem.parentAfterDrag =  this.transform;
            }
        }
    }
}
