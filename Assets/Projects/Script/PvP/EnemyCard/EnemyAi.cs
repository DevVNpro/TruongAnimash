using System;
using System.Collections;
using Projects.Script.PvP.PlayerScript;
using UnityEngine;

namespace Projects.Script.PvP.EnemyCard
{
    public class EnemyAi : MonoBehaviour
    {
        public Transform[] cardSlots;
        private Transform _transform;

        [Header("Animation Text")] [SerializeField]
        private Animator teamText;
        [Header("Animation Text")] [SerializeField]
        private Animator enemyText;

        [Header("BlockSpam")] 
        [SerializeField] private CardOnClick BlockSpam;
        private void Start()
        {
            _transform = this.transform;
        }
        
        [Header("Animaiton background Turn")] [SerializeField]
        private GameObject enemyTurn;
        [SerializeField]
        private GameObject playerTurn;

        public void StartAttackLoop()
        {
            foreach (Transform slot in cardSlots)
            {
                if (slot.childCount > 0)
                {
                    StartCoroutine(AttackPlayer(slot));
                    break;
                }
            }
        }

        IEnumerator AttackPlayer(Transform slot)
        {
            //attack player with no damage
            Transform parentAfterDrag = transform.parent;
            transform.SetParent(transform.root);
            transform.SetAsLastSibling();
            transform.LeanMove(new Vector3(slot.position.x, slot.position.y), 1.2f).setEasePunch();
            yield return new WaitForSeconds(1.4f);
            transform.LeanMove(new Vector3(_transform.position.x, _transform.position.y), 0.5f);
            transform.SetParent(parentAfterDrag);
            yield return new WaitForSeconds(0.5f);
            
            //re-enable the player's damage condition, so as not to confuse damage when the player attacks or the enemy attacks
            AttackEnemy.IsPlayerTurn = true;
            enemyTurn.SetActive(false);
            playerTurn.SetActive(true);
            BlockSpam.blockSpam.SetActive(false);
        }
       
    } 
}

