using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTextGen : MonoBehaviour
{
    [Header("Text")] [SerializeField] private Text _textGen;

    //[Header("ImgText")] [SerializeField] private Image _image;


    private void Start()
    {
      //  _image.enabled = true;
        _textGen.text = DataAnimal.Instance._nameData;
    }
}
