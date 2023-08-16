using UnityEngine;
using UnityEngine.UI;
namespace Projects.Script.PvP.PlayerScript
{
    public class ShowAttackDeck : MonoBehaviour
    {
        [SerializeField] private Card cardPlayer;
        [SerializeField] private Text textAttack;
        
        void Start()
        {
            textAttack.text = cardPlayer.attack.ToString();
        }

    
    }
}
