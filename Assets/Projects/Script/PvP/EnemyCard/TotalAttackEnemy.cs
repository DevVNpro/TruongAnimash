using System;
using Unity.VisualScripting;
using UnityEngine;

namespace Projects.Script.PvP
{
    public class TotalAttackEnemy : MonoBehaviour
    {
        [SerializeField] private Card enemy1;
        [SerializeField] private Card enemy2;
        [SerializeField] private Card enemy3;
         static public int sumAttack = 0;
        
        

        private void Update()
        {
            if (!enemy1.gameObject.activeSelf) // Kiểm tra xem enemy1 có active hay không
            {
                enemy1.attack = 0;
            }
            if (!enemy2.gameObject.activeSelf) // Kiểm tra xem enemy1 có active hay không
            {
                enemy2.attack = 0;
            }  
            if (!enemy3.gameObject.activeSelf) // Kiểm tra xem enemy1 có active hay không
            {
                enemy3.attack = 0;
            }
            sumAttack = enemy1.attack + enemy2.attack + enemy3.attack;
        }
    }
}
