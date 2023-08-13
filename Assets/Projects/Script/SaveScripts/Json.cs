using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System.IO;

public class Json : MonoBehaviour
{
  private void Start()
  { 
    string json = File.ReadAllText(Application.dataPath + "saveFile.json");
  AnimalSaveData animalSaveData = JsonUtility.FromJson<AnimalSaveData>(json);

  }
}

