using Projects.Script.Manager;
using UnityEngine;

namespace Projects.Script.GenScripts
{
   public class ShowImgGen : MonoBehaviour
   {
      private void Start()
      {
         transform.localScale = new Vector3(0f, 0f, 0f);
         transform.LeanScale(new Vector3(1.3f, 1.3f), 2.5f).setEaseOutBack();
         SoundManager.Instance.PlayVfxMuSic("finish");
      }
   }
}
