using System;
using Projects.Script.Manager;
using UnityEngine;
using UnityEngine.UI;
namespace Projects.Script.Menu
{
    public class ButtonMenu : MonoBehaviour
    {
        
        // Start is called before the first frame update

     
        public void LoadSceneTriple()
        {
            SoundManager.Instance.PlayVfxMuSic("Next");
            SceneControl.Instance.LoadScene(4);
        }
        public void LoadScenePVP()
        {
            SoundManager.Instance.PlayVfxMuSic("Next");
            SceneControl.Instance.LoadScene(5);
        }
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
