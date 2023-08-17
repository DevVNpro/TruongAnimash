using System;
using UnityEngine;
using UnityEngine.UI;
namespace Projects.Script.PvP.PlayerScript
{
    public class ShowAttackDeck : MonoBehaviour
    {
        [SerializeField] private Card cardPlayer;
        [SerializeField] private Text textAttack;
        
    

        private void Update()
        {
            textAttack.text = cardPlayer.attack.ToString();
        }
    }
}
