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
        private float time;
        private float limidTime;

        private void Awake()
        {
            time = 0;
            limidTime = 4f;
            StartCoroutine(AnimationButton());
        }

        private void Update()
        {
            time += Time.deltaTime;
            if (time >= limidTime)
            {
                gameObject.SetActive(false);
            }
        }

        IEnumerator AnimationButton()
        {
            while (true)
            {
                yield return  new WaitForSeconds(0.5f);
                image.rectTransform.LeanMove(new Vector3(-150f,410f), 0.6f);
                yield return  new WaitForSeconds(0.7f);
                image.rectTransform.LeanMove(new Vector3(-150f,-410), 0.6f);
                yield return  new WaitForSeconds(0.7f);

            }
        }
    }
}
