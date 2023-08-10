using Projects.Script.Manager;
using UnityEngine;
using UnityEngine.UI;
namespace Projects.Script.Menu
{
    public class ButtonCreate : MonoBehaviour
    {
        [SerializeField] private Button _buttonCreate;
        
        // Start is called before the first frame update
        void Start()
        {
            _buttonCreate.onClick.AddListener(NextScene);
        }

        private void NextScene()
        {
            SoundManager.Instance.PlayVfxMuSic("Next");
            SceneControl.Instance.LoadNextScene();
        }

      
        
    }
}
