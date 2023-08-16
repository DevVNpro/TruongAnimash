using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Projects.Script.PvP
{
    public class ButtonFight : MonoBehaviour
    {
        [Header("ButtonFight")]
        [SerializeField] private Button buttonFight;
        [SerializeField] private Image imageButton;
        
        [Header("TeamGrid")]
        [SerializeField] private Image TeamGrid;

        [Header("DeckGrid")] [SerializeField] private GameObject DeckGrid;

        [Header("dividingLine")] [SerializeField]
        private GameObject dividingLine;

        

        private void Awake()
        {
            StartCoroutine(AnimationButton());
            buttonFight.onClick.AddListener(Even1);
        }

        IEnumerator AnimationButton()
        {
            while (true)
            {
                transform.LeanScale(new Vector3(1.1f, 1.1f), 0.6f);
                yield return  new WaitForSeconds(0.7f);
                transform.LeanScale(new Vector3(1f, 1f), 0.6f);
                yield return  new WaitForSeconds(0.7f);

            }
        }

        private void Even1()
        {
         StartCoroutine(Test());
        }

     
        IEnumerator Test()
        {
            dividingLine.SetActive(false);
            DeckGrid.SetActive(false);
            TeamGrid.rectTransform.LeanMove(new Vector3(0f, -500f), 1.3f);
            Color color = new Color(255, 255, 255, 255);
            imageButton.color = color;
            yield return new WaitForSeconds(1.5f);          
            dividingLine.SetActive(true);
        }
      
    }
}
