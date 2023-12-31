using System;
using System.Collections;
using System.Collections.Generic;
using Projects.Script.Manager;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicPickAnimal : MonoBehaviour
{
    [Header("Button Next")] 
    [SerializeField] private Button _buttonClick;
    [SerializeField]private Image _imageButton;

    [Header("Class ShowUI")]
    [SerializeField] private ShowImageClick _showUI;

    [Header("List Button")] [SerializeField]
    private List<Button> _buttons;

    [Header("Random List Button")] [SerializeField]
    private RandomAnimal _randomButton;

    [Header("Partical System")] [SerializeField]
    private GameObject particalSystem;

    [Header("ImgText")] [SerializeField] private Image _imageText;
    
    
    [Header("BachgroundChange")]
    [SerializeField]
    private GameObject BackgroundMom;
    [SerializeField]
    private GameObject FadeBackgroundMom;
    [SerializeField]
    private GameObject FadeBackgroundDad;
    [SerializeField]
    private GameObject BackgroundGen;
    
    

    private void Start()
    {
        transform.gameObject.SetActive(false);
        _buttonClick = transform.GetComponent<Button>();
        _buttonClick.onClick.AddListener(Even1);
    



    }

    private void Even1()
    {
        //addSoundVVFX
        SoundManager.Instance.PlayVfxMuSic("Next");

        //Save name Display
        DataAnimal.Instance.SetNameData(_showUI.headText.text,_showUI.keyText.text);

        //animation 
        _showUI.MoveImgDad();
        _showUI.SetImgMom();
        
        //random Buton
        _randomButton.RandomButton();
        
        //delete selected button
        this.DeleteButton(_showUI.headText.text);
        
        //change text
        _showUI.ChangeHeadText("PICK A MOM");
        
        //delete button next
        transform.gameObject.SetActive(false);
        
        //change background
        BackgroundMom.SetActive(true);
        FadeBackgroundMom.SetActive(true);
        FadeBackgroundDad.SetActive(false);

        
        //add new Event
        _buttonClick.onClick.RemoveListener(Even1);
        _buttonClick.onClick.AddListener(Even2);
    }

    private void DeleteButton(string name)
    {
        foreach (var button in _buttons)
        {
            if (button.gameObject.name == name)
            {
                button.gameObject.SetActive(false);
            }
        }
    }

    private void Even2()
    {
        FadeBackgroundMom.SetActive(false);
        BackgroundGen.SetActive(true);
        
        //addSoundVVFX
        SoundManager.Instance.PlayVfxMuSic("Next");
        
        //Save name Display
        DataAnimal.Instance.SetNameData(_showUI.headText.text,_showUI.keyText.text);
        
        //disable text
        _imageText.enabled = false;
        _showUI.headText.gameObject.SetActive(false);
        
        //detele All Button
        this.DeActiveButton();
        
        //deactice
        _buttonClick.enabled = false;
        _imageButton.enabled = false;
        

        //animation Generation
        StartCoroutine(AnimationGeneration());


    }

    private void DeActiveButton()
    {
        foreach (var button in _buttons)
        {
           button.gameObject.SetActive(false);
        }
    }
    IEnumerator AnimationGeneration()
    {
        _showUI.imgDad.rectTransform.LeanMove(new Vector3(-241f, 241f),0.4f);
        _showUI.imgMom.rectTransform.LeanMove(new Vector3(241f, 241f), 0.4f);
        _showUI.imgDad.rectTransform.LeanScale(new Vector3(1f, 1f),0.4f);
        yield return new WaitForSeconds(1.5f);

        _showUI.imgDad.rectTransform.LeanMove(new Vector3(0f, 241f), 0.9f);
        _showUI.imgMom.rectTransform.LeanMove(new Vector3(0f, 241f), 0.9f);
        yield return new WaitForSeconds(1f);
        _showUI.imgDad.gameObject.SetActive((false));
        _showUI.imgMom.gameObject.SetActive((false));
        _showUI.headText.gameObject.SetActive(true);
        _imageText.enabled = true;
        _showUI.ChangeHeadText("GENERATING RESULT");
        particalSystem.SetActive(true);
        //add Sound VFX
        SoundManager.Instance.PlayVfxMuSic("merge_loop");
        yield return new WaitForSeconds(6f);
        particalSystem.gameObject.LeanScale(new Vector3(0f, 0f), 0.8f);
        yield return new WaitForSeconds(0.8f);
        SoundManager.Instance.TurnOffVfxSound();
        SceneControl.Instance.LoadNextScene();


    }

}
