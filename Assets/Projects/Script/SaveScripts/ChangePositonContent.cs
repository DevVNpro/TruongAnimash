using UnityEngine;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

namespace Projects.Script.SaveScripts
{
    public class ChangePositonContent : MonoBehaviour
    {
        [Header("ScollTranform")] [SerializeField]
        private RectTransform scollTranform;

        public Vector3 newPositon;

        void Start()
        {
            transform.GetComponent<Button>().onClick.AddListener(NextPage);

        }

        private void NextPage()
        {
            Vector3 currentPosition = scollTranform.anchoredPosition;

            // Cộng thêm giá trị mới vào anchoredPosition để di chuyển
            Vector3 newPosition = currentPosition + newPositon;
            scollTranform.anchoredPosition = newPosition;
        }
    }
}
