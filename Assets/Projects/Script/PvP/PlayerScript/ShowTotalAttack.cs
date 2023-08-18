using System;
using UnityEngine;
using  UnityEngine.UI;

namespace Projects.Script.PvP.PlayerScript
{
    public class ShowTotalAttack : MonoBehaviour
    {
        [SerializeField] private Text textTotalAttack;

        private void Update()
        {
            textTotalAttack.text = TotalAttackPlayer._sumAttack.ToString();
        }
    }
}
