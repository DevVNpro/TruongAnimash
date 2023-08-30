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
        [Header("Background")]
        [SerializeField] private GameObject backgroundDeck; 
        [SerializeField] private GameObject backgroundBattle;
        [SerializeField] private GameObject textBackground1;
        [SerializeField] private GameObject textBackground2;
        [SerializeField] private GameObject ButtonNextPageRight;
        [SerializeField] private GameObject ButtonNextPageLeft;

        [Header("Turn Animation")] 
        [SerializeField] private GameObject playerTurn;
        
        [Header("ButtonFight")]
        [SerializeField] private Button buttonFight;
        [SerializeField] private Image imageButton;
        
        [Header("TeamGrid")]
        [SerializeField] private Image TeamGrid;

        [Header("DeckGrid")] 
        [SerializeField] private GameObject DeckGrid;
        
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

        [Header("Loadding Text")] [SerializeField]
        private GameObject textLoading;

        [Header("List Slot")] [SerializeField] private List<GameObject> slotTeam;

        [Header("CardOnClick")] [SerializeField] private GameObject cardOnClick;
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
         StartCoroutine(StartBattle());
        }

     
        IEnumerator StartBattle()
        {
            RemoveDrabItem();
            Animation1();
            yield return new WaitForSeconds(1.3f);
            
            backgroundBattle.LeanScale(new Vector3(1f, 1f), 1f);
            yield return new WaitForSeconds(0.6f);
            
            Animation2();
            yield return new WaitForSeconds(1.5f);
            EnemyGrid.rectTransform.LeanScale(new Vector3(1f, 1f), 0.5f);
            
            
            //Animation enemt scale
            yield return new WaitForSeconds(0.6f);
            foreach (Image image in imageEnemy)
            {
                image.rectTransform.LeanScale(new Vector3(1f, 1f), 0.8f);
                yield return new WaitForSeconds(1f);
            }
            
            textLoading.SetActive(false);
            
            yield return new WaitForSeconds(0.6f);
            GameHandler.SetActive(true);
            //animation text
            playerTurn.SetActive(true);
            tutorrialAttack.SetActive(true); 
           // cardOnClick.SetActive(true);
           _cardOnClick.enabled = true;

        }

        private void RemoveDrabItem()
        {
            foreach (GameObject slot in slotTeam)
            {
                DrapAbleItem drapAbleItem = slot.GetComponentInChildren<DrapAbleItem>();
                if (drapAbleItem)
                {
                    // Vô hiệu hóa script DrapAbleItem
                    drapAbleItem.enabled = false;
                    Debug.Log("Script is disabled for " + slot.name);
                }
                else
                {
                    Debug.Log("Script is not found in " + slot.name);
                }
            }
        }
    

        

        private void Animation1()
        {
               
            backgroundDeck.SetActive(false);
            imageButton.enabled = false;
            //Turn On Click Slot Team
            
            //Change Method Sum heath
            TotalAttack.ChangeMethodSumDeck = false;
            
            //Set Animation
            DeckGrid.SetActive(false);
            TeamGrid.rectTransform.LeanMove(new Vector3(0f, -470f), 0.6f);
        }

        private void Animation2()
        {
            textBackground1.SetActive(true);
            textBackground2.SetActive(true);
            textLoading.SetActive(true);
        }
      
    }
}
