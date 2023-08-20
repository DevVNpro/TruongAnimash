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
              //thay card bang slot /, lay du lieu tu slotteam de khong phu thuoc vao card , tu do de dang thay doi card
            //chi thay doi ham totalAttackPlayer ham showtotalattack khong can thay doi vi code game ko lien quan code ui
           //lấy máu theo slot thì bị ko update máu khi chết 
            public static int _sumAttack = 0;
            int attackCard1 = 0;
            int attackCard2 = 0;
            int attackCard3 = 0;
            public static bool ChangeMethodSumDeck;

            [Header("CardPlayer")]
             private Card cardPlayer1;
             private Card cardPlayer2;
             private Card cardPlayer3;
      

            private bool checkOnSlot1;
            private bool checkOnSlot2;
            private bool checkOnSlot3;

            

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

            public void SumAttackPvP()
            {
                Debug.Log("Da chuyen phuong tthuc tinh tong diem");
                //slot1
                if (slot1.GetComponentInChildren<Card>() != null)
                {
                    checkOnSlot1 = true;
                    cardPlayer1 = slot1.GetComponentInChildren<Card>();
                  
                }
                else if(checkOnSlot1)
                {
                    attackCard1 = cardPlayer1.attack;
                }
                
                //slot2

                if (slot2.GetComponentInChildren<Card>() != null)
                {
                    checkOnSlot2 = true;
                    cardPlayer2 = slot2.GetComponentInChildren<Card>();
                 
                }
                else if(checkOnSlot2)
                {
                    attackCard2 = cardPlayer2.attack;
                }
                
                //slot3
                if (slot3.GetComponentInChildren<Card>() != null)
                {
                    checkOnSlot3 = true;
                    cardPlayer3 = slot3.GetComponentInChildren<Card>();
                   
                }
                else if(checkOnSlot3)
                {
                    attackCard3 = cardPlayer3.attack;
                }
                
                _sumAttack = attackCard1 + attackCard2 + attackCard3;
            }
    }
}
