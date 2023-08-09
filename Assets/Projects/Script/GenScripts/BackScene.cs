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
            button.onClick.AddListener(BackSceneOnclick);
            transform.position = new Vector3(-300, transform.position.y);
            StartCoroutine(AnimationButton());
            
        }

        IEnumerator AnimationButton()
        {
            yield return new WaitForSeconds(4);
            transform.LeanMove(new Vector3(540f, transform.position.y), 1f);
        }
        

        private void BackSceneOnclick()
        {
            DataAnimal.Instance.DeleteNamedata();
            SceneManager.LoadScene(sceneBuildIndex: 0);
        }
    }
}
