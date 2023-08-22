using System;
using System.Collections;
using System.Collections.Generic;
using Projects.Script.PvP.EnemyCard;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace Projects.Script.PvP.PlayerScript
{
    public class CardOnClick : MonoBehaviour
    {
        [Header("ButtonEnemy")] 
        [SerializeField]
        private PositionEnemyClick positionEnemyClick;

        [Header("List slot")] [SerializeField] private List<GameObject> listSlot;

        [Header("Onclick Listcard")]
        [SerializeField]
        private Transform Slot1;
        [SerializeField]
        private Transform Slot2;
        [SerializeField]
        private Transform Slot3;
        
        //enemyList Position
        [Header("EnemyCard")]
        [SerializeField] private Transform[] EnemyCards;
        private Transform transformButton;
        public bool  isMoving = false;
        
        [Header("Animation Text")] [SerializeField]
        private Animator teamText;

        [Header("Animation Text")] [SerializeField]
        private Animator enemyText;

        [Header("BlockSpam")] 
         public  GameObject blockSpam;
        private void Start()
        {
            CheckListSlot();
        }

        private void CheckListSlot()
        {
            foreach (GameObject slot in listSlot)
            {
                int slotIndex = listSlot.IndexOf(slot);

                if (slot.transform.childCount > 0)
                {

                    if (slotIndex == 0)
                    {
                        slot.GetComponentInChildren<Button>().onClick.AddListener(OnClickCard1);
                    }
                    else if (slotIndex == 1)
                    {
                        slot.GetComponentInChildren<Button>().onClick.AddListener(OnClickCard2);

                    }
                    else if (slotIndex == 2)
                    {
                        slot.GetComponentInChildren<Button>().onClick.AddListener(OnClickCard3);


                    }
                }
                
            }
            
            
        }

  

        public void OnClickCard1()
        {

            if (!isMoving && positionEnemyClick.transformEnemy != Vector3.zero && positionEnemyClick.targetEnemy.GetComponent<Card>().attack>0)
            {
                transformButton = Slot1.GetComponentInChildren<Button>().transform;
                blockSpam.SetActive(true);
                StartCoroutine(SetMoveAttack(transformButton));
            }
           
        }
        public void OnClickCard2()
        {

            if (!isMoving && positionEnemyClick.transformEnemy != Vector3.zero && positionEnemyClick.targetEnemy.GetComponent<Card>().attack>0)
            {
                transformButton = Slot2.GetComponentInChildren<Button>().transform;
                blockSpam.SetActive(true);
                StartCoroutine(SetMoveAttack(transformButton));
            }
           
        }
        public void OnClickCard3()
        {

            if (!isMoving && positionEnemyClick.transformEnemy != Vector3.zero && positionEnemyClick.targetEnemy.GetComponent<Card>().attack>0)
            {
                transformButton = Slot3.GetComponentInChildren<Button>().transform;
                blockSpam.SetActive(true);
                StartCoroutine(SetMoveAttack(transformButton));
            }
          
        }
        IEnumerator SetMoveAttack(Transform transformButton)
        {
            //Turn offanimation TeamText
            teamText.SetTrigger("ChangeTurn");
            //tancong enemy
            isMoving = true;
            Transform parentAfterDrag= transformButton.parent;
            transformButton.SetParent(transform.root);
            transformButton.SetAsLastSibling();
            transformButton.transform.LeanMove(new Vector3(positionEnemyClick.transformEnemy.x, positionEnemyClick.transformEnemy.y), 1.2f).setEasePunch();
            yield return  new WaitForSeconds(1.4f);
            transformButton.transform.LeanMove(new Vector3(transformButton.position.x, transformButton.position.y), 0.5f);
            transformButton.SetParent(parentAfterDrag);
            isMoving = false;
            //Turn on fanimation EnemyText
            enemyText.SetTrigger("ChangeTurn");
            yield return  new WaitForSeconds(2f);
            //xet bien cho trigger hoat dong 
            AttackPlayer.IsEnemeTurn = true;
            //xet cardEnemy attack
            foreach (Transform slot in EnemyCards)
            {
                    if (slot.childCount > 0)
                    {
                        slot.GetComponentInChildren<EnemyAi>().StartAttackLoop();
                        break;
                    }
            }
            

        }
       

    }
}
