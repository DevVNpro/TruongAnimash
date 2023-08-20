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
        [Header("ButtonBack")] [SerializeField] private Button buttonBack;


        private void Start()
        {
            buttonBack.onClick.AddListener(BackMenu);
        }

        private void Update()
        {
            if (TotalAttack._sumAttack == 0)
            {
                Invoke("TurnOnLoseImg",3f);
            }
            if (TotalAttackEnemy.sumAttack == 0)
            {
                Invoke("TurnOnWinImg",3f);
            }
        }

        private void TurnOnWinImg()
        {
            imageWin.gameObject.SetActive(true);
            buttonBack.gameObject.SetActive(true);
        }
        private void TurnOnLoseImg()
        {
            imageLose.gameObject.SetActive(true);
            buttonBack.gameObject.SetActive(true);
        }

        private void BackMenu()
        {
            SceneControl.Instance.LoadScene(0);
        }
    
     
    }
}
