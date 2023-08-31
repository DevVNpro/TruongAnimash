using System.Collections;
using System.Collections.Generic;
using Projects.Script.Manager;
using UnityEngine;
using UnityEngine.UI;

namespace Projects.Script.GenScripts
{
    public class StartAnimal : MonoBehaviour
    {
        [SerializeField]  private List<GameObject> randomStarts;
        [SerializeField] private Image _image;
        [SerializeField] private Text _text;
        static public int startNumber;
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
            Debug.Log("Số sao là :" + startNumber);
            //  int ranNumber = Random.Range(1, 8);
            int check = 0;
            _image.enabled = true;
            foreach (var star in randomStarts)
            {
                check++;
                SoundManager.Instance.PlayVfxMuSic("star");
                star.gameObject.SetActive(true);
                star.transform.LeanScale(new Vector3(1f, 1f), 1f).setEaseOutBack();
                yield return new WaitForSeconds(1f);
                if (check == startNumber)
                {
                    SoundManager.Instance.PlayVfxMuSic("stars_lock");
                    if (startNumber <= 3)
                    {
                        _text.text = "NORMAL";
                    }
                    else if(startNumber <=5)
                    {
                        _text.text = "RARE";
                    }
                    else if (startNumber == 6)
                    {
                        _text.text = "EPIC";

                    }
                    else if(startNumber == 7)
                    { 
                        _text.text = "LEGENDARY";
                    }
                    yield break;
                }
         
            }

 
        
        }
    }
}
