using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FixBattleUI : MonoBehaviour
{
    [SerializeField] private Canvas canvasScaler;
    [SerializeField] private GameObject content;
  //  [SerializeField] private float scaleFactorThreshold = 0.34f;
    [SerializeField] private float xOffset = 68f;
    [SerializeField] private float xOffset1 = 50f;

    private void Update()
    {
        ChangeOffSet();
    }

    private void ChangeOffSet()
    {
        // Kiểm tra nếu scale của Canvas nhỏ hơn scaleFactorThreshold
        if (canvasScaler.scaleFactor <  0.35f || canvasScaler.scaleFactor > 1.4f)
        {
            // Đặt giá trị space của content theo trục x là xOffset
            content.GetComponent<GridLayoutGroup>().spacing =
                new Vector2(xOffset, content.GetComponent<GridLayoutGroup>().spacing.y);
        }
        
        else
        {
            content.GetComponent<GridLayoutGroup>().spacing =
                new Vector2(xOffset1, content.GetComponent<GridLayoutGroup>().spacing.y);
        }
    }
}
