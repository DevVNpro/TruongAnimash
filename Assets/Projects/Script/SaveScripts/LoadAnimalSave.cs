using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class LoadAnimalSave : MonoBehaviour
{
    public GameObject animalPrefab;
    public Transform scrollViewContent;
    private void Start()
    {
        List<AnimalSaveData> savedAnimals = SaveManager.Instance.animalDataList;
        
        foreach (AnimalSaveData animalData in savedAnimals)
        {
            GameObject newAnimalPrefab = Instantiate(animalPrefab, scrollViewContent);
            
            Sprite loadedSprite = Resources.Load<Sprite>(animalData.imgname);
            if (loadedSprite == null)
            {
                Debug.Log("Không thể tải ảnh cho: " + animalData.name);
            }
            else
            {
                Image imageanimal = newAnimalPrefab.GetComponent<Image>();
                if (imageanimal == null)
                {
                    Debug.Log("Không tìm thấy Image component trên đối tượng: " + newAnimalPrefab.name);
                }
                else
                {
                    imageanimal.sprite = loadedSprite;
                }
            }

            newAnimalPrefab.name = animalData.name;
        }
    }

}
        
