using System;
using System.Collections;
using System.Collections.Generic;
using Projects.Script.Manager;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [Header("Setting")] [SerializeField] private GameObject setting;
    public void ResetBattle()
    {
        SoundManager.Instance.PlayVfxMuSic("Next");
        SceneControl.Instance.LoadScene(5);
    }

    public void CreateAnimal()
    {
        SoundManager.Instance.PlayVfxMuSic("Next");
        SceneControl.Instance.LoadScene(1);
    }

    public void LoadMenu()
    {
        SoundManager.Instance.PlayVfxMuSic("Next");
        SceneControl.Instance.LoadScene(0);
    }

    public void OpenSetting()
    {
        SoundManager.Instance.PlayVfxMuSic("Next");
        setting.SetActive(true);
    }

    public void CloseSetting()
    {
        SoundManager.Instance.PlayVfxMuSic("Next");
        setting.SetActive(false);
    }
    
    
}
