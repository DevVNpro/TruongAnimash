using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataAnimal : MonoBehaviour
{
    private static DataAnimal instance;
    public static DataAnimal Instance
    {
        get => instance;
    }

    public string _nameData;

    private void Start()
    {
        this.GetInstance();
    }

    private void GetInstance()
    {
        if(instance!= null) return;
        instance = this;
        DontDestroyOnLoad(instance);
    }


    public void SetNameData(string newName)
    {
        _nameData += newName;
    }
    
    
    
    
    
}
