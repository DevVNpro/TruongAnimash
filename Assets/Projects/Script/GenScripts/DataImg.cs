using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Projects.Script.GenScripts
{
    public class DataImg : MonoBehaviour
    {
        [SerializeField] private Dictionary<string, Sprite> characterImages = new Dictionary<string, Sprite>();
        [SerializeField] private Image characterImage;
        [SerializeField] private Text textKey;

        private void Awake()
        {//SHEEP
            characterImages.Add("AB", Resources.Load<Sprite>("AB"));
            characterImages.Add("AC", Resources.Load<Sprite>("AC"));
            characterImages.Add("AD", Resources.Load<Sprite>("AD"));
            characterImages.Add("AE", Resources.Load<Sprite>("AE"));
            characterImages.Add("AF", Resources.Load<Sprite>("AF"));
            characterImages.Add("AG", Resources.Load<Sprite>("AG"));
            characterImages.Add("AH", Resources.Load<Sprite>("AH"));
            characterImages.Add("AI", Resources.Load<Sprite>("AI"));
            characterImages.Add("AK", Resources.Load<Sprite>("AK"));
            characterImages.Add("AL", Resources.Load<Sprite>("AL"));
            characterImages.Add("AM", Resources.Load<Sprite>("AM"));
             characterImages.Add("AN", Resources.Load<Sprite>("AN"));
             characterImages.Add("AO", Resources.Load<Sprite>("AO"));
             characterImages.Add("AP", Resources.Load<Sprite>("AP"));
             characterImages.Add("AQ", Resources.Load<Sprite>("AQ"));
             characterImages.Add("AR", Resources.Load<Sprite>("AR"));
             characterImages.Add("AS", Resources.Load<Sprite>("AS"));
             characterImages.Add("AT", Resources.Load<Sprite>("AT"));
             characterImages.Add("AU", Resources.Load<Sprite>("AU"));
             characterImages.Add("AV", Resources.Load<Sprite>("AV"));
             characterImages.Add("AW", Resources.Load<Sprite>("AW"));
             characterImages.Add("AX", Resources.Load<Sprite>("AX"));
            //ANGEL
             characterImages.Add("BC", Resources.Load<Sprite>("BC"));
             characterImages.Add("BD", Resources.Load<Sprite>("BD"));
             characterImages.Add("BE", Resources.Load<Sprite>("BE"));
             characterImages.Add("BF", Resources.Load<Sprite>("BF"));
             characterImages.Add("BG", Resources.Load<Sprite>("BG"));
             characterImages.Add("BH", Resources.Load<Sprite>("BH"));
             characterImages.Add("BI", Resources.Load<Sprite>("BI"));
             characterImages.Add("BK", Resources.Load<Sprite>("BK"));
             characterImages.Add("BL", Resources.Load<Sprite>("BL"));
             characterImages.Add("BM", Resources.Load<Sprite>("BM"));
             characterImages.Add("BN", Resources.Load<Sprite>("BN"));
             characterImages.Add("BO", Resources.Load<Sprite>("BO"));
             characterImages.Add("BP", Resources.Load<Sprite>("BP"));
             characterImages.Add("BQ", Resources.Load<Sprite>("BQ"));
             characterImages.Add("BR", Resources.Load<Sprite>("BR"));
             characterImages.Add("BS", Resources.Load<Sprite>("BS"));
             characterImages.Add("BT", Resources.Load<Sprite>("BT"));
             characterImages.Add("BU", Resources.Load<Sprite>("BU"));
            characterImages.Add("BV", Resources.Load<Sprite>("BV"));
            characterImages.Add("BW", Resources.Load<Sprite>("BW"));
            characterImages.Add("BX", Resources.Load<Sprite>("BX"));
            //Ant
            characterImages.Add("CD", Resources.Load<Sprite>("CD"));
            characterImages.Add("CE", Resources.Load<Sprite>("CE"));
            characterImages.Add("CF", Resources.Load<Sprite>("CF"));
            characterImages.Add("CG", Resources.Load<Sprite>("CG"));
            characterImages.Add("CH", Resources.Load<Sprite>("CH"));
            characterImages.Add("CI", Resources.Load<Sprite>("CI"));
            characterImages.Add("CK", Resources.Load<Sprite>("CK"));
            characterImages.Add("CL", Resources.Load<Sprite>("CL"));
            characterImages.Add("CM", Resources.Load<Sprite>("CM"));
            characterImages.Add("CN", Resources.Load<Sprite>("CN"));
            characterImages.Add("CO", Resources.Load<Sprite>("CO"));
            characterImages.Add("CP", Resources.Load<Sprite>("CP"));
            characterImages.Add("CQ", Resources.Load<Sprite>("CQ"));
            characterImages.Add("CR", Resources.Load<Sprite>("CR"));
            characterImages.Add("CS", Resources.Load<Sprite>("CS"));
            characterImages.Add("CT", Resources.Load<Sprite>("CT"));
            characterImages.Add("CU", Resources.Load<Sprite>("CU"));
            characterImages.Add("CV", Resources.Load<Sprite>("CV"));
            characterImages.Add("CW", Resources.Load<Sprite>("CW"));
            characterImages.Add("CX", Resources.Load<Sprite>("CX"));

            



             



             
        }
        private void Start()
        {
            textKey.text = DataAnimal.Instance._keyData;
            ChangeToArray();
            this.ShowCharacterImage(textKey.text);    
            
          
        }

        private void ShowCharacterImage(string key)
        {
            // Kiểm tra xem có ảnh tương ứng với key trong Dictionary không
            if (characterImages.TryGetValue(key, out Sprite characterSprite))
            {
                // Hiển thị ảnh cho nhân vật
                characterImage.sprite = characterSprite;
            }
            else
            {
                // Nếu không tìm thấy ảnh, bạn có thể hiển thị ảnh mặc định hoặc thông báo lỗi.
                Debug.LogError("Không tìm thấy ảnh cho nhân vật " + key);
            }
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
