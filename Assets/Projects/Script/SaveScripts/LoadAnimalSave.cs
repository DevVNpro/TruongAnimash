using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using  Newtonsoft.Json;

public class LoadAnimalSave : MonoBehaviour
{
    public GameObject animalPrefab;
    public Transform scrollViewContent;
    private void Start()
    {
        List<AnimalSaveData> savedAnimals = SaveManager.Instance.animalDataList;
        LoadDataSave(ref savedAnimals);
        UpdateList(savedAnimals);

    }

    public void LoadDataSave(ref List<AnimalSaveData> savedAnimals)
    {
        string path = Application.persistentDataPath + "AnimalJsonSave.json";
        if (!File.Exists(path))
        {
            Debug.LogError($"Cannot load file at {path}. File does not exist!");
        }

        try
        {
            Debug.Log("Da gan du lieu cho json");
            Debug.Log(File.ReadAllText(path));
            savedAnimals = JsonConvert.DeserializeObject<List<AnimalSaveData>>(File.ReadAllText(path));
        }
        catch (Exception e)
        {
            Debug.LogError($"Failed to load Data due to:  {e.Message} {e.StackTrace}");
        }
    }

    public void UpdateList(List<AnimalSaveData> animalList)
    {
        Debug.Log(animalList.Capacity);
        foreach (AnimalSaveData animalData in animalList)
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
                imageanimal.sprite = loadedSprite;
            }

            newAnimalPrefab.name = animalData.name;
        }
    }

}
        
