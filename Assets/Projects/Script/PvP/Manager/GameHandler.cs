using System;
using System.Collections;
using System.Collections.Generic;
using Projects.Script.PvP.EnemyCard;
using Projects.Script.PvP.PlayerScript;
using UnityEngine;
using UnityEngine.UI;

namespace Projects.Script.PvP
{
    public class GameHandler : MonoBehaviour
    {
        [Header("WinAlert")] [SerializeField] private Image imageWin;
        [Header("WinAlert")] [SerializeField] private Image imageLose;

        [Header("DeckTeam")] [SerializeField] private RectTransform dectTeam;
        [Header("EnemyTeam")] [SerializeField] private RectTransform enemyTeam;

        [Header("ButtonWinLose")] [SerializeField] private GameObject buttonWinLose;

        [Header("TextBattle")] [SerializeField]  private GameObject textBattle;


    
        private void Update()
        {

            if (TotalAttack._sumAttack == 0)
            {
                StartCoroutine(TurnOnLoseImg());
            }
            if (TotalAttackEnemy.sumAttack == 0)
            {
                StartCoroutine(TurnOnWinImg());
            }
        }
        IEnumerator TurnOnWinImg()
        {
            yield return  new WaitForSeconds(3f);
            textBattle.SetActive(false);
            enemyTeam.gameObject.SetActive(false);
            dectTeam.LeanMove(new Vector3(0f, 0f, 0f), 1.5f).setEasePunch();
            yield return  new WaitForSeconds(1.6f);
            buttonWinLose.SetActive(true);
            imageWin.gameObject.SetActive(true);
        }
        IEnumerator TurnOnLoseImg()
        {
            yield return  new WaitForSeconds(3f);
            textBattle.SetActive(false);
            dectTeam.gameObject.SetActive(false);
            enemyTeam.LeanMove(new Vector3(0f, 0f, 0f), 1.5f).setEasePunch();
            yield return  new WaitForSeconds(1.5f);
            buttonWinLose.SetActive(true);
            imageLose.gameObject.SetActive(true);
        }

      
    
     
    }
}
