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

        [Header("ListPlayer")] [SerializeField]
        private List<Transform> ListPlayer;

        private bool playerAlve;
        private void Start()
        {
            buttonBack.onClick.AddListener(BackMenu);
        }

        private void BackMenu()
        {
            SceneControl.Instance.LoadScene(0);
        }
        private void Update()
        {
            /*foreach (Transform card in ListPlayer)
            {
                if (card.childCount > 0)
                {

                    playerAlve = true;
                }
                else
                {
                    playerAlve = false;
                }
            }
            if (TotalAttack._sumAttack == 0 &&!playerAlve)
            {
                imageLose.gameObject.SetActive(true);
                buttonBack.gameObject.SetActive(true);
            }*/

            if (TotalAttackEnemy.sumAttack == 0)
            {
                Invoke("TurnOnLoseImg",3f);
            }
        }

        private void TurnOnLoseImg()
        {
            imageWin.gameObject.SetActive(true);
            buttonBack.gameObject.SetActive(true);
        }
    }
}
