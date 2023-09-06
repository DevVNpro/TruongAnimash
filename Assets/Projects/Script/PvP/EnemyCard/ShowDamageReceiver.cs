using System.Collections;
using TMPro;
using UnityEngine;

namespace Projects.Script.PvP.EnemyCard
{
    public class ShowDamageReceiver : MonoBehaviour
    {

        [SerializeField] private TextMeshProUGUI textDamageReceiver;
        // Start is called before the first frame update

        public void StartShow(int damage)
        {
            StartCoroutine(ShowText(damage));
        }
        
        IEnumerator ShowText(int damage)
        {            
            RectTransform rectTransform = GetComponent<RectTransform>();
            rectTransform.localScale = new Vector3(1,1,1);
            textDamageReceiver.text ="-"+damage.ToString();
            yield return  new WaitForSeconds(0.1f);
            TextMoveUp();
            yield return  new WaitForSeconds(2f);
            textDamageReceiver.text = "-";
            rectTransform.anchoredPosition = new Vector2(rectTransform.anchoredPosition.x,-218f);
            rectTransform.localScale = new Vector3(0,0,0);
            
        }

        public void TextMoveUp()
        {
            RectTransform rectTransform = GetComponent<RectTransform>();
            LeanTween.move(rectTransform, new Vector3(rectTransform.anchoredPosition.x, 141f), 2f);
        }
    }
}
