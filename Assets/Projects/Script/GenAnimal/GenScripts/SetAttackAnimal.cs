using System.Collections;
using UnityEngine;

namespace Projects.Script.GenAnimal.GenScripts
{
    public class SetAttackAnimal : MonoBehaviour
    {
        private int[] attackLv1 = {100, 200, 300, 400};
        private int[] attackLv2 = {500,600};
        private int[] attackLv3 = {800,900};
        public static int setAttack;
        public static int  attack;
        void Start()
        {
            StartCoroutine(GetAttack());

        }

        IEnumerator GetAttack()
        {
            yield return new WaitForSeconds(3f);
            if (setAttack == 2)
            {
                int randomIndex = Random.Range(0, attackLv1.Length);
                attack = attackLv1[randomIndex];
            }
            else if (setAttack == 4)
            {
                int randomIndex = Random.Range(0, attackLv2.Length);
                attack = attackLv2[randomIndex];
            }
            else if (setAttack == 6)
            {
                int randomIndex = Random.Range(0, attackLv3.Length);
                attack = attackLv3[randomIndex];                
            }
            Debug.Log("Số Attack là:" + attack);
        }

        
        
    }
}
