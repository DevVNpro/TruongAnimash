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
                    Debug.Log("Người chơi tấn công");
                    break;
                case (GameState.EnemyTurn):
                    Debug.Log("Kẻ định tấn công");
                    break;
                case (GameState.GameOver):
                    Debug.Log("Kết thúc game");
                    break;
            }
        }
    }
}
