using Unity.VisualScripting;
using UnityEngine;

namespace Projects.Script.PvP
{
    public class TotalAttackEnemy : MonoBehaviour
    {
        [SerializeField] private Card enemy1;
        [SerializeField] private Card enemy2;
        [SerializeField] private Card enemy3;
        public int sumAttack = 0;
        
        
        // Start is called before the first frame update
        void Start()
        {
            sumAttack = enemy1.attack + enemy2.attack + enemy3.attack;
        }

 
    }
}
