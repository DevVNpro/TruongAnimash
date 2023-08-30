using UnityEngine;
using UnityEngine.UI;

namespace Projects.Script
{
    public class FixCollectionUi : MonoBehaviour
    {
        [SerializeField] private Canvas canvasScaler;
        [SerializeField] private GameObject content;
     
        private void Update()
        {
            ChangeOffset();
        }

        private void ChangeOffset()
        {
           // Kiểm tra nếu scale của Canvas nhỏ hơn scaleFactorThreshold
           if (canvasScaler.scaleFactor <  0.35f || canvasScaler.scaleFactor > 1.2f) {
                // Đặt giá trị space của content theo trục x là xOffset
                content.GetComponent<GridLayoutGroup>().spacing = new Vector2(80, 100);
               // scrollView.anchoredPosition = new Vector2(-31,-94);
           }
        
           else
           {
               content.GetComponent<GridLayoutGroup>().spacing = new Vector2(60, 80);
             //  scrollView.anchoredPosition = new Vector2(12,-189);
           }
        }
    }
}
