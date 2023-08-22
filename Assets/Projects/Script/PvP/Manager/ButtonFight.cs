using System;
using System.Collections;
using System.Collections.Generic;
using Projects.Script.PvP.PlayerScript;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace Projects.Script.PvP
{
    public class ButtonFight : MonoBehaviour
    {
        [Header("GameHandler")] 
        [SerializeField] private GameObject GameHandler;
        
        [Header("ButtonFight")]
        [SerializeField] private Button buttonFight;
        [SerializeField] private Image imageButton;
        
        [Header("TeamGrid")]
        [SerializeField] private Image TeamGrid;

        [Header("DeckGrid")] 
        [SerializeField] private GameObject DeckGrid;

        [Header("dividingLine")]
        [SerializeField] private GameObject dividingLine;
        
        [Header("LoadingText")]
        [SerializeField] private GameObject LoadingText;

        [Header("EnemyGrid")]
        [SerializeField] private Image EnemyGrid;

        [Header("ActiveOnClickSlot")]
        [SerializeField] private CardOnClick _cardOnClick;

        [Header("AnimationImgEnemy")] 
        [SerializeField] private List<Image> imageEnemy;

        [Header("Animation Text")]
        [SerializeField] private Animator teamText;

        [Header("Tutorial Attack")] [SerializeField]
        private GameObject tutorrialAttack;
    

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
            //Turn On Click Slot Team
            _cardOnClick.enabled = true;
            
            //Change Method Sum heath
            TotalAttack.ChangeMethodSumDeck = false;
            
            //Set Animation
            dividingLine.SetActive(false);
            DeckGrid.SetActive(false);
            TeamGrid.rectTransform.LeanMove(new Vector3(0f, -500f), 1.3f);
            imageButton.enabled = false;
            buttonFight.GetComponentInChildren<Text>().enabled = false;
            
            yield return new WaitForSeconds(1.5f);          
            dividingLine.SetActive(true);
            LoadingText.SetActive(true);
            
            yield return new WaitForSeconds(1.5f);
            EnemyGrid.rectTransform.LeanScale(new Vector3(1f, 1f), 0.5f);
            
            //Set position attack
            yield return new WaitForSeconds(0.6f);
            foreach (Image image in imageEnemy)
            {
                image.rectTransform.LeanScale(new Vector3(1f, 1f), 0.8f);
                yield return new WaitForSeconds(1f);
            }
            yield return new WaitForSeconds(0.6f);
            LoadingText.SetActive(false);
            GameHandler.SetActive(true);
            //animation text
            teamText.SetTrigger("Fight");
            tutorrialAttack.SetActive(true);

    }
      
    }
}
