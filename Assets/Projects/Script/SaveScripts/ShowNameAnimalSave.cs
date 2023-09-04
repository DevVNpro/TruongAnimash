using System.Collections;
using System.Collections.Generic;
using Projects.Script.Manager;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ShowNameAnimalSave : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private GameObject _gameObjecttext;
    [SerializeField] private Text _text;

    void Start()
    {
        //get button
        _button = transform.GetComponent<Button>();
        _button.onClick.AddListener(ShowimgAndText);
        

        //get text
        _gameObjecttext = GameObject.FindGameObjectWithTag("text");
        _text = _gameObjecttext.GetComponent<Text>();

    }

    private void ShowimgAndText()
    {
        this.SetText();
        this.AddSoundVfx();
    }

    private void SetText()
    {
        _text.text = _button.name;
        
    }
    private void AddSoundVfx()
    {
        SoundManager.Instance.PlayVfxMuSic("Click");
    }
  



}
