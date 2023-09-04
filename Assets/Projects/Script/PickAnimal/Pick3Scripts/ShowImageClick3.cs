using Projects.Script.Manager;
using Projects.Script.PickScripts;
using UnityEngine;
using UnityEngine.UI;

namespace Projects.Script.Pick3Scripts
{
  public class ShowImageClick3 : MonoBehaviour
  {
    [Header("Animal")] 
    [SerializeField] private Button _buttonAnimal;
      
    [Header("ImgAnimal")]
    [SerializeField] public Image img1;
    [SerializeField] public Image img2;
    [SerializeField] public Image img3;
    public static Image imgDisplay;
      
    [Header("HeadText")]
    public Text headText;
    
    //test save key to find in dictionary
    [Header(("Key"))] 
    public Text keyText;
    public DatakeyAnimal datakey;
       
    [Header("NextButton")] [SerializeField]
    private Button _nextButton;
    
    
      
    private void Start()
    {
     this.AddOnClickevent();
      imgDisplay = img1;
        
    }
      
    private void AddOnClickevent()
    {
      _buttonAnimal= transform.GetComponent<Button>();
      _buttonAnimal.onClick.AddListener(ShowChose);
    }
    
    public void ShowChose()
    {
     // this.AddSoundVfx();
      this.SetAnimationImgDisplay();
      this.SetImg();
      this.SetTextName();
      this.EnableNextButton();
      this.DisplayKey();
    
    }
    
    /*
    private void AddSoundVfx()
    {
      SoundManager.Instance.PlayVfxMuSic("Click");
    }
    */
      
    
    public void SetAnimationImgDisplay()
    {
      imgDisplay.transform.localScale = new Vector2(2f, 2f);
      imgDisplay.transform.LeanScale(Vector2.one, 0.1f);
    }
    
    
    public void SetImg()
    {
      imgDisplay.sprite = _buttonAnimal.image.sprite;
    }
    
    
    public void SetTextName()
    {
      headText.text = _buttonAnimal.gameObject.name;
    }
    
    public void EnableNextButton()
    {
      _nextButton.gameObject.SetActive(true);
    }
      
    //to chage display img when pick dad animal
    public void SetImg2()
    {
      imgDisplay = img2;
    }

    public void SetImg3()
    {
      imgDisplay = img3;
    }
    //To move the imgDaa 
    public void MoveImg1()
    {
      imgDisplay.rectTransform.LeanMove((Vector3)new Vector2 (-335f, 562f), 0.4f);
      imgDisplay.rectTransform.LeanScale(new Vector2(0.5f, 0.5f),0.4f);
    
    }
    public void MoveImg2()
    {
      imgDisplay.rectTransform.LeanMove((Vector3)new Vector2 (335f, 562f), 0.4f);
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
}
