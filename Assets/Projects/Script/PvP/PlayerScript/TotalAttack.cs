using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Projects.Script.PvP.PlayerScript
{
    public class TotalAttack : MonoBehaviour
    {
            [Header("ListSlots")]
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
            public static bool ChangeMethodSumDeck;

            [Header("CardPlayer")]
            [SerializeField] private Card cardPlayer1;
            [SerializeField] private Card cardPlayer2;
            [SerializeField] private Card cardPlayer3;
            

            private void Start()
            {
                ChangeMethodSumDeck = true;
            }

            private void Update()
            {
                if (ChangeMethodSumDeck)
                {
                    SumAttackSoftDeck();

                }
                else
                {
                    SumAttackPvP();
                }
            }

            public void SumAttackSoftDeck()
            {
                Debug.Log("Da chuyen phuong tthuc tinh tong diem");
                if (slot1.GetComponentInChildren<Card>() != null)
                {
                    attackCard1 = slot1.GetComponentInChildren<Card>().attack;
                    slot1.GetComponentInChildren<Card>().onSlot = true;
                }
                else
                {
                    attackCard1 = 0;
                    cardPlayer1.onSlot = false;

                }
                
                if (slot2.GetComponentInChildren<Card>() != null)
                {
                    attackCard2 = slot2.GetComponentInChildren<Card>().attack;
                    slot2.GetComponentInChildren<Card>().onSlot = true;

                }
                else
                {
                    attackCard2 = 0;
                    cardPlayer2.onSlot = false;

                }
                
                if (slot3.GetComponentInChildren<Card>() != null)
                {
                    attackCard3 = slot3.GetComponentInChildren<Card>().attack;
                    slot3.GetComponentInChildren<Card>().onSlot = true;

                }
                else
                {
                    attackCard3 = 0;
                    cardPlayer3.onSlot = false;

                }
                _sumAttack = attackCard1 + attackCard2 + attackCard3;
            }

            public void SumAttackPvP()
            {
                if (cardPlayer1.onSlot == true)
                {
                    attackCard1 = cardPlayer1.attack;
                }
                else attackCard1 = 0;
                if (cardPlayer2.onSlot == true)
                {
                    attackCard2 = cardPlayer2.attack;
                }
                else attackCard2 = 0;
                if (cardPlayer3.onSlot == true)
                {
                    attackCard3 = cardPlayer3.attack;
                }
                else attackCard3 = 0;
                _sumAttack = attackCard1 + attackCard2 + attackCard3;
            }
    }
}
