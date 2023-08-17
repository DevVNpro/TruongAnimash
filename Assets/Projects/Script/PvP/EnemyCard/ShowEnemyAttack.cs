using System;
using UnityEngine;
using  UnityEngine.UI;
namespace Projects.Script.PvP.EnemyCard
{
    public class ShowEnemyAttack : MonoBehaviour
    { 
        [Header("AttackSum")]
        [SerializeField] private TotalAttackEnemy totalAttackEnemy;
        
        [Header("AttackText")]
        [SerializeField] private Text textAttack;
    
    

        private void Update()
        {
            textAttack.text = totalAttackEnemy.sumAttack.ToString();
        }
    }
}
