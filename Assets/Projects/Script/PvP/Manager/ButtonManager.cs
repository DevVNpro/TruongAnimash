using System.Collections;
using System.Collections.Generic;
using Projects.Script.Manager;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public void LoadMenu()
    {
        SoundManager.Instance.PlayVfxMuSic("Next");
        SceneControl.Instance.LoadScene(0);
    }

    public void PopUp()
    {
        Debug.Log("PopUp");
    }
}
