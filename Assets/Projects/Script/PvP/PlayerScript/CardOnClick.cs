using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Projects.Script.PvP.PlayerScript
{
    public class CardOnClick : MonoBehaviour
    {
        [Header("ButtonEnemy")] 
        [SerializeField]
        private PositionEnemyClick positionEnemyClick;
        [Header("ButtonPlayer")] 
        [SerializeField]
        private Button buttonPlayer1;
        [SerializeField]
        private Button buttonPlayer2;
        [SerializeField]
        private Button buttonPlayer3;

     
        

        private Transform transformButton;
    
    

        private bool  isMoving = false;

        private void Start()
        {

            buttonPlayer1.onClick.AddListener(OnClickCard1); 
            buttonPlayer2.onClick.AddListener(OnClickCard2);
           buttonPlayer3.onClick.AddListener(OnClickCard3);
        }

  

        public void OnClickCard1()
        {
            transformButton = buttonPlayer1.transform;
            if (!isMoving && positionEnemyClick.transformEnemy != Vector3.zero)
            {
                StartCoroutine(SetMoveAttack(transformButton));
            }
            else
            {
                Debug.Log("chua chon doi thu");
            }
        }
        public void OnClickCard2()
        {
            transformButton = buttonPlayer2.transform;
            if (!isMoving && positionEnemyClick.transformEnemy != Vector3.zero)
            {
                StartCoroutine(SetMoveAttack(transformButton));
            }
            else
            {
                Debug.Log("chua chon doi thu");
            }
        }
        public void OnClickCard3()
        {
            transformButton = buttonPlayer3.transform;
            if (!isMoving && positionEnemyClick.transformEnemy != Vector3.zero)
            {
                StartCoroutine(SetMoveAttack(transformButton));
            }
            else
            {
                Debug.Log("chua chon doi thu");
            }
        }
        IEnumerator SetMoveAttack(Transform transformButton)
        {
            isMoving = true;
            Transform parentAfterDrag= transformButton.parent;
            transformButton.SetParent(transform.root);
            transformButton.SetAsLastSibling();
            transformButton.transform.LeanMove(new Vector3(positionEnemyClick.transformEnemy.x, positionEnemyClick.transformEnemy.y), 1.2f).setEasePunch();
            yield return  new WaitForSeconds(1.4f);
            transformButton.transform.LeanMove(new Vector3(transformButton.position.x, transformButton.position.y), 0.5f);
            transformButton.SetParent(parentAfterDrag);
            isMoving = false;
            yield return  new WaitForSeconds(0.5f);
        }
       

    }
}
