using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveManager : MonoBehaviour
{
    private static SaveManager instance;
    public static SaveManager Instance => instance;
    public List<AnimalSaveData> DataSaves = new List<AnimalSaveData>();

    private void Start()
    {
        if (instance != null)
        {
         Destroy(this);
         return;
        }
        instance = this;
        DontDestroyOnLoad(this);
    }

    public void AddNewAnimal(string name, Sprite img)
    {
        DataSaves.Add(new AnimalSaveData(name,img));
        Debug.Log("So luong phan tu la :"+DataSaves.Count);
    }


    
    
    
}
