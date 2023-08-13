using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalInfoViewer : MonoBehaviour
{
    public GameObject animalPrefab;
    public Transform scrollViewContent;

    private void Start()
    {
        // Lấy danh sách các con thú đã lưu từ Singleton SaveManager
        List<AnimalSaveData> savedAnimals = SaveManager.Instance.DataSaves;

        // Duyệt qua danh sách và tạo các Prefab tương ứng
        foreach (AnimalSaveData animalData in savedAnimals)
        {
            // Tạo một Prefab mới từ Prefab gốc
            GameObject newAnimalPrefab = Instantiate(animalPrefab, scrollViewContent);
            

            // Lấy tham chiếu đến các thành phần trong Prefab
            Image animalImage = newAnimalPrefab.GetComponent<Image>();

            // Đặt thông tin và ảnh của con thú vào Prefab
            animalImage.sprite = animalData.img;
            newAnimalPrefab.name = animalData.name;

        }
    }
}