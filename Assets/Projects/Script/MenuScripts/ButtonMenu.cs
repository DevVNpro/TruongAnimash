using Projects.Script.Manager;
using UnityEngine;
using UnityEngine.UI;
namespace Projects.Script.Menu
{
    public class ButtonMenu : MonoBehaviour
    {
        
        // Start is called before the first frame update
 

        public void NextScene()
        {
            SoundManager.Instance.PlayVfxMuSic("Next");
            SceneControl.Instance.LoadNextScene();
        }

        public void SaveScene()
        {
            SoundManager.Instance.PlayVfxMuSic("Next");
            SceneControl.Instance.LoadScene(3);
        }

      
        
    }
}
