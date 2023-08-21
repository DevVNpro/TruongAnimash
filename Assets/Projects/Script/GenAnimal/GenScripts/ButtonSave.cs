using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.UI;

namespace Projects.Script.GenScripts
{
    public class ButtonSave : MonoBehaviour
    {
        [Header("imgSaveButton")] [SerializeField]
        private Image _img;

        [Header("ButtonSave")] [SerializeField]
        private Button _button;

        [Header("HeadText")] [SerializeField] private Text _text;
        [Header("Key")] [SerializeField] private Text _Key;
        int[] attackValues = { 100, 200, 300, 400,500,600 };
        private int attack;
        private void  Start()
        {
            int randomIndex = Random.Range(0, attackValues.Length);
             attack = attackValues[randomIndex];
            transform.localScale = new Vector3(0f,0f);
            StartCoroutine(AnimationButton());
            
        }

        IEnumerator AnimationButton()
        {
            yield return new WaitForSeconds(5);
            transform.LeanScale(new Vector3(1f, 1f), 1f);
        }
  
        public void SaveData()
        {
            string path = Application.persistentDataPath + "AnimalJsonSave.json";
            string jsonContent = File.ReadAllText(path);
            if (jsonContent != "")
            {
                foreach (AnimalSaveData animmal in SaveManager.Instance.animalDataList)
                {
                    if (animmal.key == DataAnimal.Instance._keyData)
                    {
                        _button.image.color = Color.grey;
                        _button.enabled = false;
                        _text.fontSize = 45;
                        _text.text = "Characters already in the collection";
                        DataAnimal.Instance.DeleteNamedata();
                        return;
                    }
                }
                SaveManager.Instance.AddNewAnimal(DataAnimal.Instance._nameData, _Key.text,DataAnimal.Instance._keyData,attack);
                _button.image.color = Color.grey;
                _button.enabled = false;
                SaveToJsonWithContent(SaveManager.Instance.animalDataList);
                DataAnimal.Instance.DeleteNamedata();
            }
            else
            {
                SaveManager.Instance.AddNewAnimal(DataAnimal.Instance._nameData, _Key.text,DataAnimal.Instance._keyData,attack);
                _button.image.color = Color.grey;
                _button.enabled = false;
                SaveToJsonWithNoContent(SaveManager.Instance.animalDataList);
                DataAnimal.Instance.DeleteNamedata();

            }
        }

        public void SaveToJsonWithContent(List<AnimalSaveData>  listAnimal)
        {
            Debug.Log("SaveWithContent");
            string path = Application.persistentDataPath + "AnimalJsonSave.json";
            /*List<AnimalSaveData> existingData = new List<AnimalSaveData>();
            string existingJson = File.ReadAllText(path);
            existingData = JsonConvert.DeserializeObject<List<AnimalSaveData>>(existingJson);
            existingData.AddRange(listAnimal);*/
            using FileStream stream = File.Create(path);
            stream.Close();
            File.WriteAllText(path, JsonConvert.SerializeObject(listAnimal));
        }

        public void SaveToJsonWithNoContent(List<AnimalSaveData> listAnimal)
        {
            Debug.Log("SaveWithNoContent");
            string path = Application.persistentDataPath + "AnimalJsonSave.json";
            File.WriteAllText(path, JsonConvert.SerializeObject(listAnimal));
        }

    }
}
