using UnityEngine;
using Sirenix.OdinInspector;
using UnityEngine.UI;
namespace Projects.Script.ScripableObject.GenAnimal
{
    [CreateAssetMenu(fileName = "new GenAnimal", menuName = "GenAnimal")]
    public class GenSO : SerializedScriptableObject
    {
        [SerializeField] private string key;
        [SerializeField] private Sprite characterImg;

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
