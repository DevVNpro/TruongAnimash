using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
namespace Projects.Script.PvP.Manager
{
    public class LoadDataSavePvP : MonoBehaviour
    {
        [Header("PrefabsCard")] 
        [SerializeField] private GameObject card;

        [Header("Content")]
        [SerializeField] private Transform content;
        void Start()
        {
            string path = Application.persistentDataPath + "AnimalJsonSave.json";
            string jsonConten = File.ReadAllText(path);
            if (jsonConten != "")
            {
              LoadDataSave(SaveManager.Instance.animalDataList);        
                Debug.Log(" co du lieu");

            }
            else
            {
                Debug.Log("Khong co du lieu");
            }
        }

        private void LoadDataSave(List<AnimalSaveData> animalList)
        {
            foreach (AnimalSaveData animalData in animalList)
            {
                GameObject newAnimalPrefab = Instantiate(card, content);
                //do something with data
                
                
                Sprite loadedSprite = Resources.Load<Sprite>(animalData.imgname);
                if (loadedSprite == null)
                {
                    Debug.Log("Không thể tải ảnh cho: " + animalData.name);
                }
                else
                {
                    Transform childTransform = newAnimalPrefab.transform.Find("Deck1");
                    childTransform.GetComponent<Image>().sprite = loadedSprite;
                }

                newAnimalPrefab.name = animalData.name;
                newAnimalPrefab.GetComponentInChildren<Card>().attack = animalData.attack;
            }



        }

       
    }
}
