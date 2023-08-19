using System;
using UnityEngine;
using  UnityEngine.UI;
namespace Projects.Script.PvP.EnemyCard
{
    public class ShowEnemyAttack : MonoBehaviour
    { 

        
        [Header("AttackText")]
        [SerializeField] private Text textAttack;

        private void Update()
        {
            textAttack.text = TotalAttackEnemy.sumAttack.ToString();
        }
    }
}
