using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ShowTextGen : MonoBehaviour
{
    [Header("Text")] 
    [SerializeField] private Text textGen;

    //khong thuộc lớp này
  //  [Header("Key")] 
   // [SerializeField] private Text textkey;



    private void Start()
    {
      //  _image.enabled = true;
        textGen.text = DataAnimal.Instance._nameData;
      //  textkey.text = DataAnimal.Instance._keyData;
        //this.ChangeToArray();
       // Debug.Log(textkey.text);
        
    }
    // không thuộc lớp này để test sẽ để trong dateimg để tìm kiếm key
    /*private void ChangeToArray()
    {
        char[] charArray = textkey.text.ToCharArray();
        Array.Sort(charArray); // Sắp xếp mảng char theo thứ tự bảng chữ cái

        string sortedString = new string(charArray); // Chuyển mảng char thành chuỗi đã sắp xếp
        textkey.text = sortedString; 
    }*/
}
