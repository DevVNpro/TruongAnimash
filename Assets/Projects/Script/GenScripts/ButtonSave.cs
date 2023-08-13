using System.Collections;
using System.Collections.Generic;
using Projects.Script.Manager;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSave : MonoBehaviour
{
    [Header("imgSaveButton")] [SerializeField]
    private Image _img;

    [Header("ButtonSave")] [SerializeField]
    private Button _button;
    private void  Start()
    {
        transform.localScale = new Vector3(0f,0f);
        StartCoroutine(AnimationButton());
            
    }

    IEnumerator AnimationButton()
    {
        yield return new WaitForSeconds(5);
        transform.LeanScale(new Vector3(1f, 1f), 1f);
    }
    public void AddSaveAnimal()
    {   
        SoundManager.Instance.PlayVfxMuSic("Next");
        Debug.Log("Ten nhan vat vua save:" + DataAnimal.Instance._nameData);
        SaveManager.Instance.AddNewAnimal(DataAnimal.Instance._nameData, _img.sprite);
        _button.image.color = Color.grey;
        _button.enabled = false;
        DataAnimal.Instance.DeleteNamedata();
    }
}
