using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Projects.Script.GenAnimal.GenScripts;
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
        /*int[] attacklv1 = { 100, 200, 300, 400,500,600 };
        private int attack;*/
        private void  Start()
        {
            /*int randomIndex = Random.Range(0, attacklv1.Length);
             attack = attacklv1[randomIndex];*/
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
            /*string fileName = "AnimalJsonSave.json";
            string path = Path.Combine(Application.persistentDataPath, fileName);*/
            Debug.Log("SaveWithContent");
            string path = Application.persistentDataPath + "AnimalJsonSave.json";
            if (File.Exists(path))
            {
                Debug.Log("1");
                foreach (AnimalSaveData animmal in SaveManager.Instance.animalDataList)
                {
                    if (animmal.key == DataAnimal.Instance._keyData)
                    {
                        _button.image.color = Color.grey;
                        _button.enabled = false;
                        _text.fontSize = 60;
                        _text.text = "DUPLICATE";
                        DataAnimal.Instance.DeleteNamedata();
                        return;
                    }
                }
                
                SaveManager.Instance.AddNewAnimal(DataAnimal.Instance._nameData, _Key.text,DataAnimal.Instance._keyData,AttackAnimal.attack);
                _button.image.color = Color.grey;
                _button.enabled = false;
                SaveToJsonWithContent(SaveManager.Instance.animalDataList);
                DataAnimal.Instance.DeleteNamedata();
            }
            else
            {
                Debug.Log("2");
                SaveManager.Instance.AddNewAnimal(DataAnimal.Instance._nameData, _Key.text,DataAnimal.Instance._keyData,AttackAnimal.attack);
                _button.image.color = Color.grey;
                _button.enabled = false;
                SaveToJsonWithContent(SaveManager.Instance.animalDataList);
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

        /*public void SaveToJsonWithNoContent(List<AnimalSaveData> listAnimal,string path)
        {
            Debug.Log("SaveWithNoContent");
            string jsonContent = JsonConvert.SerializeObject(listAnimal);
            File.WriteAllText(path, jsonContent);
        }*/

    }
}
