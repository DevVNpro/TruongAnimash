using System;
using TMPro;
using UnityEngine;
using  UnityEngine.UI;

namespace Projects.Script.PvP.PlayerScript
{
    public class ShowTotalAttack : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI textTotalAttack;

        private void Update()
        {
            textTotalAttack.text = TotalAttack.sumAttack.ToString();
        }
    }
}
