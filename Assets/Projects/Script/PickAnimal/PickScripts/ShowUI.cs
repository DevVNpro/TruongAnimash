using System;
using System.Collections;
using System.Collections.Generic;
using Projects.Script.Manager;
using Projects.Script.PickScripts;
using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShowUI : MonoBehaviour
{ 
  [Header("Animal")] 
  [SerializeField] private Button _buttonAnimal;
  
  [Header("ImgAnimal")]
  [SerializeField] public Image imgDad;
  [SerializeField] public Image imgMom;
  public static Image imgDisplay;
  
  [Header("HeadText")]
   public Text headText;

   //test save key to find in dictionary
   [Header(("Key"))] 
   public Text keyText;
   public Datakey datakey;
   
  [Header("NextButton")] [SerializeField]
  private Button _nextButton;

 


  private void Start()
  {
    this.AddOnClickevent();
    imgDisplay = imgDad;
    
  }
  
  private void AddOnClickevent()
  {
   _buttonAnimal= transform.GetComponent<Button>();
    _buttonAnimal.onClick.AddListener(ShowChose);
  }

  private void ShowChose()
  {
    this.AddSoundVfx();
    this.SetAnimationImgDisplay();
    this.SetImg();
    this.SetTextName();
    this.EnableNextButton();
    this.DisplayKey();

  }

  private void AddSoundVfx()
  {
    SoundManager.Instance.PlayVfxMuSic("Click");
  }
  

  private void SetAnimationImgDisplay()
  {
    imgDisplay.transform.localScale = new Vector2(2f, 2f);
    imgDisplay.transform.LeanScale(Vector2.one, 0.1f);
  }


  private void SetImg()
  {
    imgDisplay.sprite = _buttonAnimal.image.sprite;
  }


  private void SetTextName()
  {
    headText.text = _buttonAnimal.gameObject.name;
  }

  private void EnableNextButton()
  {
    _nextButton.gameObject.SetActive(true);
  }
  
  //to chage display img when pick dad animal
  public void SetImgMom()
  {
    imgMom.gameObject.SetActive(true);
    imgDisplay = imgMom;
  }
  //To move the imgDaa 
  public void MoveImgDad()
  {
    imgDisplay.rectTransform.LeanMove((Vector3)new Vector2 (-226, 176), 0.4f);
    imgDisplay.rectTransform.LeanScale(new Vector2(0.5f, 0.5f),0.4f);

  }
  //To chage HeadText
  public void ChangeHeadText(string text)
  {
    headText.text = text;
  }

  public void DisplayKey()
  {
    keyText.text = datakey.animalKey.Key;
  }


}
