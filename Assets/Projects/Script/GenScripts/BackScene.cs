using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Projects.Script.GenScripts
{
    public class BackScene : MonoBehaviour
    {
        [SerializeField] private Button button;
        void Start()
        {
            button.onClick.AddListener(BackSceneOnclick);
        }

        private void BackSceneOnclick()
        {
            DataAnimal.Instance.DeleteNamedata();
            SceneManager.LoadScene(sceneBuildIndex: 0);
        }
    }
}
