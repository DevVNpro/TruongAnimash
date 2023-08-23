using System;
using System.Collections;
using Projects.Script.Manager;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Projects.Script.GenScripts
{
    public class ButtonManagerGenScene : MonoBehaviour
    {
        
  
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

        public void LoadSceneBattle()
        {
            SoundManager.Instance.PlayVfxMuSic("Next");
            DataAnimal.Instance.DeleteNamedata();
            SceneControl.Instance.LoadScene(5);
        }
        
        

        public void BackSceneClick()
        {
            SoundManager.Instance.PlayVfxMuSic("Next");
            DataAnimal.Instance.DeleteNamedata();
           SceneControl.Instance.BackScene();
        }

        public void BackMenuClick()
        {
            SoundManager.Instance.PlayVfxMuSic("Next");
            DataAnimal.Instance.DeleteNamedata();
            SceneControl.Instance.MenuScene();
        }
  

    }
}
