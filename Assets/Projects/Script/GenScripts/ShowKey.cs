using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowKey : MonoBehaviour
{

    [SerializeField] private Text _text;
    // Update is called once per frame
    private void Start()
    {
        _text.text = DataAnimal.Instance._keyData;
    }
}
