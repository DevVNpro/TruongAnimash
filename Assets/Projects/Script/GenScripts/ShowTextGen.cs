using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ShowTextGen : MonoBehaviour
{
    [Header("Text")] 
    [SerializeField] private Text textGen;

    [SerializeField] private Image imgText;

    private void Awake()
    {
        imgText.enabled = false;
    }

    private void Start()
    {

        StartCoroutine(ShowText());

    }

    IEnumerator ShowText()
    {
        yield return  new WaitForSeconds(2f);
        textGen.text = DataAnimal.Instance._nameData;
        imgText.enabled = true;
        
    }

}
