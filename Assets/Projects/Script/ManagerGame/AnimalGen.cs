using System;
using UnityEngine;
using Sirenix.OdinInspector;
using UnityEngine.UI;
namespace Projects.Script.ScripableObject.GenAnimal
{
    
    [Serializable]
    public class AnimalGen
    {
        [SerializeField] private string key;
        [SerializeField] private Sprite characterImg;
        [SerializeField] private int star;

        public AnimalGen(string key, Sprite img)
        {
            this.key = key;
            characterImg = img;    
        }
        
        public string Key
        {
            get => key;
        }

        public Sprite CharacterImg
        {
            get => characterImg;
        }

        public int Star => star;
    }
}
