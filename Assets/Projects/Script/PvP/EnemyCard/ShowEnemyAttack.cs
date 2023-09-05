using System;
using TMPro;
using UnityEngine;
using  UnityEngine.UI;
namespace Projects.Script.PvP.EnemyCard
{
    public class ShowEnemyAttack : MonoBehaviour
    { 

        
        [Header("AttackText")]
        [SerializeField] private TextMeshProUGUI textTotalAttack;

        private void Update()
        {
            textTotalAttack.text = TotalAttackEnemy.sumAttack.ToString();
        }
    }
}
