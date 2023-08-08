using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;
namespace Projects.Script.ScripableObject.GenAnimal
{
    public class ManagerGenSo : MonoBehaviour
    {
       
           [SerializeField]
         [ListDrawerSettings(ShowPaging = true)] 
         private GenSO[] characterDataArray;
            [SerializeField] private Image characterImage;
            [SerializeField] private Text textKey;

            private void Start()
            {
                textKey.text = DataAnimal.Instance._keyData;
                ChangeToArray();
                ShowCharacterImage(textKey.text);
            }

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
                char[] charArray = textKey.text.ToCharArray();
                Array.Sort(charArray); // Sắp xếp mảng char theo thứ tự bảng chữ cái

                string sortedString = new string(charArray); // Chuyển mảng char thành chuỗi đã sắp xếp
                textKey.text = sortedString;

            }
        
    }
}
