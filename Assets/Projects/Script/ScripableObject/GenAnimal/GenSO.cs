using System;
using UnityEngine;
using Sirenix.OdinInspector;
using UnityEngine.UI;
namespace Projects.Script.ScripableObject.GenAnimal
{
    
    [Serializable]
    public class GenSO
    {
        [SerializeField] private string key;
        [SerializeField] private Sprite characterImg;

        public GenSO(string key, Sprite img)
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
    }
}
