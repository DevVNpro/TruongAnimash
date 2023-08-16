using System;
using UnityEngine;

namespace Projects.Script.PvP
{
    public class AttackPlayer : MonoBehaviour
    {
        public int attack;

        private void Awake()
        {
            attack = 500;
        }
    }
}
