using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace Projects.Script.PvP.PlayerScript
{
    public class TotalAttackPlayer : MonoBehaviour
    {
   
            [SerializeField] private GameObject player1;
            [SerializeField] private GameObject player2;
            [SerializeField] private GameObject player3;
            //thay card bang slot /, lay du lieu tu slotteam de giam phu thuoc vao card , tu do de dang thay doi card
            //chi thay doi ham totalAttackPlayer ham showtotalattack khong can thay doi vi code game ko lien quan code ui
            public static int _sumAttack = 0;
            int attackCard1 = 0;
            int attackCard2 = 0;
            int attackCard3 = 0;
    
            private void Update()
            {
                


                if (player1.GetComponentInChildren<Card>() != null)
                {
                    attackCard1 = player1.GetComponentInChildren<Card>().attack;
                }
           
                
                
                if (player2.GetComponentInChildren<Card>() != null)
                {
                    attackCard2 = player2.GetComponentInChildren<Card>().attack;
                }
             
                
                
                if (player3.GetComponentInChildren<Card>() != null)
                {
                    attackCard3 = player3.GetComponentInChildren<Card>().attack;
                }

                _sumAttack = attackCard1 + attackCard2 + attackCard3;
            }
    }
}
