using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImgOverlay : MonoBehaviour
{
    public Material overlayMaterial; // Tham chiếu tới Material hỗ trợ độ trong suốt
    public Image img;

    void Start()
    {
        // Lấy reference đến Sprite Renderer của ảnh
        img = transform.GetComponent<Image>();

        // Gán Material vào Sprite Renderer để tạo hiệu ứng overlay
        img.material = overlayMaterial;
    }
}
