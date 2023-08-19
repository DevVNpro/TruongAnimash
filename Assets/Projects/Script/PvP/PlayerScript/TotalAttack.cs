using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Projects.Script.PvP.PlayerScript
{
    public class TotalAttack : MonoBehaviour
    {
   
        [SerializeField] private GameObject slot1; 
        [SerializeField] private GameObject slot2;
        [SerializeField] private GameObject slot3;
            //thay card bang slot /, lay du lieu tu slotteam de giam phu thuoc vao card , tu do de dang thay doi card
            //chi thay doi ham totalAttackPlayer ham showtotalattack khong can thay doi vi code game ko lien quan code ui
           //lấy máu theo slot thì bị ko update máu khi chết 
            public static int _sumAttack = 0;
            int attackCard1 = 0;
            int attackCard2 = 0;
            int attackCard3 = 0;
    
            private void Update()
            {
                
                if (slot1.GetComponentInChildren<Card>() != null)
                {
                    attackCard1 = slot1.GetComponentInChildren<Card>().attack;
                }
               
                else
                {
                    attackCard1 = 0;
                }
                
                if (slot2.GetComponentInChildren<Card>() != null)
                {
                    attackCard2 = slot2.GetComponentInChildren<Card>().attack;
                }
                else
                {
                    attackCard2 = 0;
                }
                
                if (slot3.GetComponentInChildren<Card>() != null)
                {
                    attackCard3 = slot3.GetComponentInChildren<Card>().attack;
                }
                else
                {
                    attackCard3 = 0;
                }

                _sumAttack = attackCard1 + attackCard2 + attackCard3;
            }
    }
}
