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
    
        void Start()
        {
            textAttack.text = totalAttackEnemy.sumAttack.ToString();
        }

 
    }
}
