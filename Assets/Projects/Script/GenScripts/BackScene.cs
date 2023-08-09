using System;
using System.Collections;
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
            transform.LeanScale(new Vector3(2f, 2f), 1f);
        }
        

        private void BackSceneOnclick()
        {
            DataAnimal.Instance.DeleteNamedata();
            SceneManager.LoadScene(sceneBuildIndex: 0);
        }
    }
}
