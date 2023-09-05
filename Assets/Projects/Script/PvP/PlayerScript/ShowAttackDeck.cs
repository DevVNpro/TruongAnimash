using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
namespace Projects.Script.PvP.PlayerScript
{
    public class ShowAttackDeck : MonoBehaviour
    {
        [SerializeField] private Card cardPlayer;
        [SerializeField] private TextMeshProUGUI textAttack;
        
    

        private void Update()
        {
            textAttack.text = cardPlayer.attack.ToString();
        }
    }
}
