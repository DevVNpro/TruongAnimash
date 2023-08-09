using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Projects.Script.GenScripts
{
    public class RandomStart : MonoBehaviour
    {
        [SerializeField]  private List<GameObject> randomStarts;
        [SerializeField] private Image _image;
        [SerializeField] private Text _text;
        void Start()
        {            
            this.SetScaleStart();
            StartCoroutine(RandomStar());
        }

        private void SetScaleStart()
        {
            foreach (var star in randomStarts)
            {
                star.transform.localScale = new Vector3(0f,0f);
            }
        }

        IEnumerator RandomStar()
        {
            yield return new WaitForSeconds(3f);
            int ranNumber = Random.Range(1, 8);
            int check = 0;
            _image.enabled = true;
            foreach (var star in randomStarts)
            {
                check++;
                star.gameObject.SetActive(true);
                star.transform.LeanScale(new Vector3(1f, 1f), 1f).setEaseOutBack();
                yield return new WaitForSeconds(1f);
                if (check == ranNumber)
                {
                    if (ranNumber <= 3)
                    {
                        _text.text = "NORMAL";
                    }
                    else if(ranNumber <=5)
                    {
                        _text.text = "RARE";
                    }
                    else if (ranNumber == 6)
                    {
                        _text.text = "EPIC";

                    }
                    else if(ranNumber == 7)
                    { 
                        _text.text = "LEGENDARY";
                    }
                    yield break;
                }
         
            }

 
        
        }
    }
}
