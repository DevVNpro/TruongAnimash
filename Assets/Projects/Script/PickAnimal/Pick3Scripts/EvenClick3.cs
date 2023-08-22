using System.Collections;
using System.Collections.Generic;
using Projects.Script.Manager;
using UnityEngine;
using UnityEngine.UI;

namespace Projects.Script.Pick3Scripts
{
    public class EvenClick3 : MonoBehaviour
    {
        [Header("Button Next")] 
        [SerializeField] private Button _buttonClick;
        [SerializeField]private Image _imageButton;
        [SerializeField] private Text _TextButtonClick;

        [Header("Class ShowUI")]
        [SerializeField] private ShowUI3 _showUI3;

        [Header("List Button")] [SerializeField]
        private List<Button> _buttons;

        [Header("Random List Button")] [SerializeField]
        private RandomAnimal _randomButton;

        [Header("Partical System")] [SerializeField]
        private GameObject particalSystem;

        [Header("ImgText")] [SerializeField] private Image _imageText;
    
    

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
            DataAnimal.Instance.SetNameData(_showUI3.headText.text,_showUI3.keyText.text);
        
            //save Key
        

            //animation 
            _showUI3.MoveImg1();
            _showUI3.SetImg2();
        
            //random Buton
            _randomButton.RandomButton();
        
            //delete selected button
            this.DeleteButton(_showUI3.headText.text);
        
            //change text
            _showUI3.ChangeHeadText("PICK IMAGE 2");
        
            //delete button next
            transform.gameObject.SetActive(false);
        
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
            //addSoundVVFX
           SoundManager.Instance.PlayVfxMuSic("Next");
        
            //setimg2
            _showUI3.MoveImg2();
            _showUI3.SetImg3();

            //Save name Display
            DataAnimal.Instance.SetNameData(_showUI3.headText.text,_showUI3.keyText.text);
        
          
          //random Buton
          _randomButton.RandomButton();
        
          //delete selected button
          this.DeleteButton(_showUI3.headText.text);
        
          //change text
          _showUI3.ChangeHeadText("PICK IMAGE 3");
        
          //delete button next
          transform.gameObject.SetActive(false);
        
          //add new Event
          _buttonClick.onClick.RemoveListener(Even2);
         _buttonClick.onClick.AddListener(Even3);
        }

        private void Even3()
        { //disable text
        _imageText.enabled = false;
        _showUI3.headText.gameObject.SetActive(false);
        //set name and key
        DataAnimal.Instance.SetNameData(_showUI3.headText.text,_showUI3.keyText.text);

        //detele All Button
        this.DeActiveButton();

        //deactice
        _buttonClick.enabled = false;
        _imageButton.enabled = false;
        _TextButtonClick.enabled = false;

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
            _showUI3.img3.rectTransform.LeanScale(new Vector3(0.5f, 0.5f), 0.4f);
            _showUI3.img3.rectTransform.LeanMove(new Vector3(0f, 550f), 0.4f);
            _showUI3.img1.rectTransform.LeanMove(new Vector3(0f, 550f), 0.8f);
           _showUI3.img2.rectTransform.LeanMove(new Vector3(0f, 550f), 0.8f);

            yield return new WaitForSeconds(0.5f);
            _showUI3.img1.rectTransform.LeanScale(new Vector3(1f, 1), 0.5f);
            _showUI3.img2.rectTransform.LeanScale(new Vector3(1f, 1f), 0.5f);
            _showUI3.img1.rectTransform.LeanScale(new Vector3(1f, 1f), 0.5f);

            yield return new WaitForSeconds(0.7f);
           _showUI3.img1.gameObject.SetActive((false));
           _showUI3.img2.gameObject.SetActive((false));
           _showUI3.img3.gameObject.SetActive((false));
           _showUI3.headText.gameObject.SetActive(true);
            _imageText.enabled = true;
            _showUI3.ChangeHeadText("GENERATING RESULT");
            particalSystem.SetActive(true);
            //add Sound VFX
           SoundManager.Instance.PlayVfxMuSic("merge_loop");
            yield return new WaitForSeconds(4f);
            particalSystem.SetActive(false);
            SoundManager.Instance.TurnOffVfxSound();
           SceneControl.Instance.LoadScene(2);
        
        }
    }
}
