using System.Collections;
using System.Collections.Generic;
using Projects.Script.Manager;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ShowUiSave : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private GameObject _gameObjectimg;
    [SerializeField] private Image _image;
    [SerializeField] private GameObject _gameObjecttext;
    [SerializeField] private Text _text;

    void Start()
    {
        //get button
        _button = transform.GetComponent<Button>();
        _button.onClick.AddListener(ShowimgAndText);
        
        //get img 
        _gameObjectimg = GameObject.FindGameObjectWithTag("img");
        _image= _gameObjectimg.GetComponent<Image>();

        //get text
        _gameObjecttext = GameObject.FindGameObjectWithTag("text");
        _text = _gameObjecttext.GetComponent<Text>();

    }

    private void ShowimgAndText()
    {
        this.SetImgAndText();
        this.AddSoundVfx();
        this.SetAnimationImgDisplay();
    }

    private void SetImgAndText()
    {
        _image.sprite = _button.image.sprite;
        _text.text = _button.name;
        
    }
    private void AddSoundVfx()
    {
        SoundManager.Instance.PlayVfxMuSic("Click");
    }
  

    private void SetAnimationImgDisplay()
    {
        _image.transform.localScale = new Vector2(1.5f, 1.5f);
        _image.transform.LeanScale(Vector2.one, 0.1f);
    }

}
