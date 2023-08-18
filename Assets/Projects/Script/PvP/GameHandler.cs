using System;
using System.Collections;
using System.Collections.Generic;
using Projects.Script.PvP.EnemyCard;
using Projects.Script.PvP.PlayerScript;
using UnityEngine;

namespace Projects.Script.PvP
{
    public class GameHandler : MonoBehaviour
    {
        public static GameHandler instance;

        public TotalAttackEnemy totalAttackEnemy;

        public AttackEnemy attackEnemy;

        public GameObject winAlert;
        public GameState game;

        public EnemyAi enemyAi1;

        public enum GameState
        {
            PlayerTurn,
            EnemyTurn,
            GameOver
        }

        private void Start()
        {
            game = GameState.PlayerTurn;
        }

        private void Update()
        {

            switch (game){
                case (GameState.PlayerTurn):
                    Debug.Log("PlayerTurn");
                    if (totalAttackEnemy.sumAttack == 0)
                    {
                        game = GameState.GameOver;
                    }
                    if (AttackEnemy.IsPlayerTurn == false)
                    {

                        game = GameState.EnemyTurn;
                    }

                    break;
                case (GameState.EnemyTurn):
                    Debug.Log("EnemyTurn");
                    enemyAi1.StartAttackLoop();
                    game = GameState.PlayerTurn;
                    break;

                case (GameState.GameOver):
                    Debug.Log("Kết thúc game");
                    winAlert.SetActive(true);
                    break;
            }
        }

        IEnumerator AttackPlayer()
        {           
            yield return  new WaitForSeconds(1f);
            enemyAi1.StartAttackLoop();
            yield return  new WaitForSeconds(1f);
            game = GameState.PlayerTurn;
        }





    }
}
