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
            //Anteaters
            characterImages.Add("DE", Resources.Load<Sprite>("DE"));
            characterImages.Add("DF", Resources.Load<Sprite>("DF"));
            characterImages.Add("DG", Resources.Load<Sprite>("DG"));
            characterImages.Add("DH", Resources.Load<Sprite>("DH"));
            characterImages.Add("DI", Resources.Load<Sprite>("DI"));
            characterImages.Add("DK", Resources.Load<Sprite>("DK"));
            characterImages.Add("DL", Resources.Load<Sprite>("DL"));
            characterImages.Add("DM", Resources.Load<Sprite>("DM"));
            characterImages.Add("DN", Resources.Load<Sprite>("DN"));
            characterImages.Add("DO", Resources.Load<Sprite>("DO"));
            characterImages.Add("DP", Resources.Load<Sprite>("DP"));
            characterImages.Add("DQ", Resources.Load<Sprite>("DQ"));
            characterImages.Add("DR", Resources.Load<Sprite>("DR"));
            characterImages.Add("DS", Resources.Load<Sprite>("DS"));
            characterImages.Add("DT", Resources.Load<Sprite>("DT"));
            characterImages.Add("DU", Resources.Load<Sprite>("DU"));
            characterImages.Add("DV", Resources.Load<Sprite>("DV"));
            characterImages.Add("DW", Resources.Load<Sprite>("DW"));
            characterImages.Add("DX", Resources.Load<Sprite>("DX"));

            //Pangolin
            characterImages.Add("EF", Resources.Load<Sprite>("EF"));
            characterImages.Add("EG", Resources.Load<Sprite>("EG"));
            characterImages.Add("EH", Resources.Load<Sprite>("EH"));
            characterImages.Add("EI", Resources.Load<Sprite>("EI"));
            characterImages.Add("EK", Resources.Load<Sprite>("EK"));
            characterImages.Add("EL", Resources.Load<Sprite>("EL"));
            characterImages.Add("EM", Resources.Load<Sprite>("EM"));
            characterImages.Add("EN", Resources.Load<Sprite>("EN"));
            characterImages.Add("EO", Resources.Load<Sprite>("EO"));
            characterImages.Add("EP", Resources.Load<Sprite>("EP"));
            characterImages.Add("EQ", Resources.Load<Sprite>("EQ"));
            characterImages.Add("ER", Resources.Load<Sprite>("ER"));
            characterImages.Add("ES", Resources.Load<Sprite>("ES"));
            characterImages.Add("ET", Resources.Load<Sprite>("ET"));
            characterImages.Add("EU", Resources.Load<Sprite>("EU"));
            characterImages.Add("EV", Resources.Load<Sprite>("EV"));
            characterImages.Add("EW", Resources.Load<Sprite>("EW"));
            characterImages.Add("EX", Resources.Load<Sprite>("EX"));
            //Astronaut
            characterImages.Add("FG", Resources.Load<Sprite>("FG"));
            characterImages.Add("FH", Resources.Load<Sprite>("FH"));
            characterImages.Add("FI", Resources.Load<Sprite>("FI"));
            characterImages.Add("FK", Resources.Load<Sprite>("FK"));
            characterImages.Add("FL", Resources.Load<Sprite>("FL"));
            characterImages.Add("FM", Resources.Load<Sprite>("FM"));
            characterImages.Add("FN", Resources.Load<Sprite>("FN"));
            characterImages.Add("FO", Resources.Load<Sprite>("FO"));
            characterImages.Add("FP", Resources.Load<Sprite>("FP"));
            characterImages.Add("FQ", Resources.Load<Sprite>("FQ"));
            characterImages.Add("FR", Resources.Load<Sprite>("FR"));
            characterImages.Add("FS", Resources.Load<Sprite>("FS"));
            characterImages.Add("FT", Resources.Load<Sprite>("FT"));
            characterImages.Add("FU", Resources.Load<Sprite>("FU"));
            characterImages.Add("FV", Resources.Load<Sprite>("FV"));
            characterImages.Add("FW", Resources.Load<Sprite>("FW"));
            characterImages.Add("FX", Resources.Load<Sprite>("FX"));


            //Avacado
            
            //Pinkfish
            characterImages.Add("HI", Resources.Load<Sprite>("HI"));
            characterImages.Add("HK", Resources.Load<Sprite>("HK"));
            characterImages.Add("HL", Resources.Load<Sprite>("HL"));
            characterImages.Add("HM", Resources.Load<Sprite>("HM"));
            characterImages.Add("HN", Resources.Load<Sprite>("HN"));
            characterImages.Add("HO", Resources.Load<Sprite>("HO"));
            characterImages.Add("HP", Resources.Load<Sprite>("HP"));
            characterImages.Add("HQ", Resources.Load<Sprite>("HQ"));
            characterImages.Add("HR", Resources.Load<Sprite>("HR"));
            characterImages.Add("HS", Resources.Load<Sprite>("HS"));
            characterImages.Add("HT", Resources.Load<Sprite>("HT"));
            characterImages.Add("HU", Resources.Load<Sprite>("HU"));
            characterImages.Add("HV", Resources.Load<Sprite>("HV"));
            characterImages.Add("HW", Resources.Load<Sprite>("HW"));
            characterImages.Add("HX", Resources.Load<Sprite>("HX"));


            
            
            




             



             
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
