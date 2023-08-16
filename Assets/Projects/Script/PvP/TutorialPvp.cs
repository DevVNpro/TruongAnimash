using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Projects.Script.PvP
{
    public class TutorialPvp : MonoBehaviour
    {
        [SerializeField] private Image image;
        // Start is called before the first frame update
      

        private void Awake()
        {
            StartCoroutine(AnimationButton());
        }

        IEnumerator AnimationButton()
        {
            while (true)
            {
                yield return  new WaitForSeconds(0.5f);
                image.rectTransform.LeanMove(new Vector3(10f,400f), 0.6f);
                yield return  new WaitForSeconds(0.7f);
                image.rectTransform.LeanMove(new Vector3(10f,-600f), 0.6f);
                yield return  new WaitForSeconds(0.7f);

            }
        }
    }
}
