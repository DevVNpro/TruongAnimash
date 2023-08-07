using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EvenClick : MonoBehaviour
{
    [Header("Button Next")] 
    [SerializeField] private Button _buttonClick;

    [Header("Class ShowUI")]
    [SerializeField] private ShowUI _showUI;

    [Header("List Button")] [SerializeField]
    private List<Button> _buttons;

    [Header("Random List Button")] [SerializeField]
    private RandomAnimal _randomButton;

    [Header("Partical System")] [SerializeField]
    private GameObject particalSystem;

    [Header("ImgText")] [SerializeField] private Image _imageText;
    
    

    private void Start()
    {
        _buttonClick = transform.GetComponent<Button>();
        _buttonClick.onClick.AddListener(Even1);
    



    }

    private void Even1()
    {
        DataAnimal.Instance.SetNameData(_showUI.headText.text);
        _showUI.MoveImgDad();
        _showUI.SetImgMom();
        _randomButton.RandomButton();
        this.DeleteButton(_showUI.headText.text);
        _showUI.ChangeHeadText("PICK A MOM");
        transform.gameObject.SetActive(false);
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
        DataAnimal.Instance.SetNameData(_showUI.headText.text);
        _imageText.enabled = false;
        _showUI.headText.gameObject.SetActive(false);
        this.DeActiveButton();
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

        _showUI.imgMom.rectTransform.LeanMove(new Vector3(260f, 562f), 0.4f);
        _showUI.imgDad.rectTransform.LeanScale(new Vector3(1f, 1f),0.4f);
        yield return new WaitForSeconds(1.5f);

        _showUI.imgDad.rectTransform.LeanMove(new Vector3(0f, 562f), 0.7f);
        _showUI.imgMom.rectTransform.LeanMove(new Vector3(0f, 562f), 0.7f);
        yield return new WaitForSeconds(0.7f);
        _showUI.imgDad.gameObject.SetActive((false));
        _showUI.imgMom.gameObject.SetActive((false));
        _showUI.headText.gameObject.SetActive(true);
        _imageText.enabled = true;
        _showUI.ChangeHeadText("Generation....");
        particalSystem.SetActive(true);
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(1);


    }

}
