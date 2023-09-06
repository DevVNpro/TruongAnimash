using System;
using System.Collections.Generic;
using Projects.Script.PvP.PlayerScript;
using UnityEngine;

namespace Projects.Script.PvP.Slot
{
    public class CheckSlotEnable : MonoBehaviour
    {
        
        [SerializeField] private GameObject buttonFight;
        private void Update()
        {
            if (TotalAttack.sumAttack == 0)
            {
                buttonFight.gameObject.SetActive(false);
            }
            else
            {
                buttonFight.gameObject.SetActive(true);
            }
            
        }
    }
}
