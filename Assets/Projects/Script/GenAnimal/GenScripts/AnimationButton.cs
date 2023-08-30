using System.Collections;
using UnityEngine;

namespace Projects.Script.GenAnimal.GenScripts
{
    public class AnimationButton : MonoBehaviour
    {
        private void  Start()
        {
            transform.localScale = new Vector3(0f,0f);
            StartCoroutine(AnimationButtonn());
            
        }
        IEnumerator AnimationButtonn()
        {
            yield return new WaitForSeconds(5);
            transform.LeanScale(new Vector3(1f, 1f), 1f);
        }
    }
}
