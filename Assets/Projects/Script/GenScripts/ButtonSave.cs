using System.Collections;
using System.Collections.Generic;
using Projects.Script.Manager;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ButtonSave : MonoBehaviour
{
    [Header("imgSaveButton")] [SerializeField]
    private Image _img;

    [Header("ButtonSave")] [SerializeField]
    private Button _button;

    [Header("HeadText")] [SerializeField] private Text _text;
    [Header("Key")] [SerializeField] private Text _Key;
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
        foreach (AnimalSaveData animmal in SaveManager.Instance.animalDataList)
        {
            if (animmal.key == DataAnimal.Instance._keyData)
            {
                _button.image.color = Color.grey;
                _button.enabled = false;
                _text.fontSize = 45;
                _text.text = "Characters already in the collection";
                DataAnimal.Instance.DeleteNamedata();
                return;
            }

        }
        SaveManager.Instance.AddNewAnimal(DataAnimal.Instance._nameData, _Key.text,DataAnimal.Instance._keyData);
        _button.image.color = Color.grey;
        _button.enabled = false;
        DataAnimal.Instance.DeleteNamedata();
    }
}
