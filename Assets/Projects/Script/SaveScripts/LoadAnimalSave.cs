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

        public Sprite BorderLv1;
        public Sprite BorderLv2;
        public Sprite BorderLv3;
        
        public Sprite BackgroundLv1;
        public Sprite BackgroundLv2;
        public Sprite BackgroundLv3;
        
        private void Start()
        {
           
            string path = Application.persistentDataPath + "AnimalJsonSave.json";
            if (File.Exists(path))
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
                    Image boderImage = newAnimalPrefab.GetComponent<Image>();
                    Transform backgroundCard = newAnimalPrefab.transform.Find("BackgroundCard");
                    if (animalData.attack >= 400)
                    {
                        boderImage.sprite = BorderLv3;
                         Image test =  backgroundCard.GetComponent<Image>();
                        test.sprite  = BackgroundLv3;
                        Transform  imageCard = backgroundCard.Find("ImagedCard");
                        Image test1  = imageCard.GetComponent<Image>();
                        test1.sprite = loadedSprite;
                     
                    }
                }

                newAnimalPrefab.name = animalData.name;
            }
        }

    }
}
        
