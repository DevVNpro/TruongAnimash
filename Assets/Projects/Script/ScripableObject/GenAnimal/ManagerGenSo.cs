using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
namespace Projects.Script.ScripableObject.GenAnimal
{
    public class ManagerGenSo : MonoBehaviour
    {
       
           [SerializeField]
         private GenSO[] characterDataArray;

         [SerializeField] private string SpritePath = "Assets/Projects/Resources";
            [SerializeField] private Image characterImage;

            private void Start()
            {
                ChangeToArray();
                ShowCharacterImage(DataAnimal.Instance._keyData);
            }

#if UNITY_EDITOR
            
            [Button]
            void GenData()
            {
                var listSpriteGUID = AssetDatabase.FindAssets("t:texture2D", new[] {SpritePath});
                var listSprite = new List<Sprite>();
                foreach (string s in listSpriteGUID)
                {
                    var sprite = AssetDatabase.LoadAssetAtPath<Sprite>(AssetDatabase.GUIDToAssetPath(s));
                    listSprite.Add(sprite);
                }

                characterDataArray = new GenSO[listSprite.Count];
                for (var i = 0; i < characterDataArray.Length; i++)
                {
                    characterDataArray[i] = new GenSO(listSprite[i].name, listSprite[i]);
                }
            }
#endif
        
            private void ShowCharacterImage(string key)
            {
                foreach (GenSO characterData in characterDataArray)
                {
                    if (characterData.Key == key)
                    {
                        characterImage.sprite = characterData.CharacterImg;
                        return;
                    }
                }

                Debug.LogError("Không tìm thấy dữ liệu cho nhân vật " + key);
            }
            private void ChangeToArray()
            {
                char[] charArray = DataAnimal.Instance._keyData.ToCharArray();
                Array.Sort(charArray); // Sắp xếp mảng char theo thứ tự bảng chữ cái

                string sortedString = new string(charArray); // Chuyển mảng char thành chuỗi đã sắp xếp
                DataAnimal.Instance._keyData = sortedString;

            }
        
    }
}
