using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;

namespace Projects.Script.MenuScripts
{
    public class LoadDataSave : MonoBehaviour
    {

        void Start()
        {
          string path = Application.persistentDataPath + "AnimalJsonSave.json";
            string jsonConten = File.ReadAllText(path);
            if (jsonConten != "")
            {
                LoadDataSave1(ref SaveManager.Instance.animalDataList);
                Debug.Log(" co du lieu");

            }
            else
            {
                Debug.Log("Khong co du lieu");
            }

        }

      
        public void LoadDataSave1(ref List<AnimalSaveData> savedAnimals)
        {
            string path = Application.persistentDataPath + "AnimalJsonSave.json";
            if (!File.Exists(path))
            {
                Debug.LogError($"Cannot load file at {path}. File does not exist!");
            }

            try
            {
                Debug.Log(File.ReadAllText(path));
                savedAnimals = JsonConvert.DeserializeObject<List<AnimalSaveData>>(File.ReadAllText(path));
            }
            catch (Exception e)
            {
                Debug.LogError($"Failed to load Data due to:  {e.Message} {e.StackTrace}");
            }
        }
    }
}
