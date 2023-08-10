using System;
using System.Collections;
using Projects.Script.Manager;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Projects.Script.GenScripts
{
    public class BackScene : MonoBehaviour
    {
        [SerializeField] private Button button;
        private void  Start()
        {
            transform.localScale = new Vector3(0f,0f);
            button.onClick.AddListener(BackSceneOnclick);
            StartCoroutine(AnimationButton());
            
        }

        IEnumerator AnimationButton()
        {
            yield return new WaitForSeconds(5);
            transform.LeanScale(new Vector3(1f, 1f), 1f);
        }
        

        private void BackSceneOnclick()
        {
            SoundManager.Instance.PlayVfxMuSic("Next");
            DataAnimal.Instance.DeleteNamedata();
           SceneControl.Instance.BackScene();
        }
    }
}
