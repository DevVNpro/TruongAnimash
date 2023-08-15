using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
namespace Projects.Script.SaveScripts
{
    public class LoadAnimalSave : MonoBehaviour
    {
        public GameObject animalPrefab;
        public Transform scrollViewContent;
        private void Start()
        {
           
            string path = Application.persistentDataPath + "AnimalJsonSave.json";
            string jsonConten = File.ReadAllText(path);
            if (jsonConten != "")
            {
                UpdateList(SaveManager.Instance.animalDataList);        
                Debug.Log(" co du lieu");

            }
            else
            {
                Debug.Log("Khong co du lieu");
            }
        }



        public void UpdateList(List<AnimalSaveData> animalList)
        {
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
}
        
