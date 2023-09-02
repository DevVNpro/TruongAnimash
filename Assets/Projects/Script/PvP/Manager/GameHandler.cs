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

        [Header("TextBattle")] [SerializeField]  private GameObject textBattlePlayer;
        [SerializeField]  private GameObject textBattleEnemy;

        [Header("Background")] [SerializeField]
        private RectTransform backgroundEnemy;
       
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
            textBattlePlayer.SetActive(false);
            textBattleEnemy.SetActive(false);
            enemyTeam.gameObject.SetActive(false);
            dectTeam.gameObject.SetActive(false);
        //    LeanTween.move(backgroundEnemy, new Vector3(backgroundEnemy.anchoredPosition.x, -2000f), 2f).setEase(LeanTweenType.easeOutQuad);
            yield return  new WaitForSeconds(2f);
            buttonWinLose.SetActive(true);
            imageWin.gameObject.SetActive(true);
        }
        IEnumerator TurnOnLoseImg()
        {
            yield return  new WaitForSeconds(3f);
            textBattlePlayer.SetActive(false);
            textBattleEnemy.SetActive(false);
            dectTeam.gameObject.SetActive(false);
            enemyTeam.gameObject.SetActive(false);
            buttonWinLose.SetActive(true);
            imageLose.gameObject.SetActive(true);
        }

      
    
     
    }
}
