using System;
using System.Collections;
using System.Collections.Generic;
using Projects.Script.PvP.PlayerScript;
using UnityEngine;

namespace Projects.Script.PvP
{
    public class GameHandler : MonoBehaviour
    {
        public static GameHandler instance;

        public TotalAttackEnemy totalAttackEnemy;

        public AttackEnemy attackEnemy;

        public GameObject WinAlert;
        public GameState game;

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
            switch (game)
            {
                case(GameState.PlayerTurn):
                    Debug.Log("PlayerTurn");
                    if (totalAttackEnemy.sumAttack == 0)
                    {
                        game = GameState.GameOver;
                    }

                    if (AttackEnemy.IsPlayerTurn == false)
                    {
                        game = GameState.EnemyTurn;
                        Debug.Log("EnemyTurn");
                  
                        
                    }
                    
                    
                    break;
                case (GameState.EnemyTurn):
                    Debug.Log("EnemyTurn");
                    //xu li enemy danh
                    //attackEnemy.IsPlayerTurn = true;
                    game = GameState.EnemyTurn;
                    break;
                case (GameState.GameOver):
                     Debug.Log("Kết thúc game");
                     WinAlert.SetActive(true);
                    break;
            }
        }
        
    }
}
