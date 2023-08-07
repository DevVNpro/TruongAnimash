using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class RandomStart : MonoBehaviour
{
    [SerializeField]  private List<GameObject> randomStarts;
    [SerializeField] private Image _image;
    [SerializeField] private Text _text;
    void Start()
    {            
        StartCoroutine(RandomStar());
    }

    IEnumerator RandomStar()
    {
        int ranNumber = Random.Range(1, 8);
        yield return new WaitForSeconds(1.2f);
        int check = 0;
        _image.enabled = true;
        foreach (var star in randomStarts)
        {
            check++;
            star.gameObject.SetActive(true);
            yield return new WaitForSeconds(0.2f);
            if (check == ranNumber)
            {
                if (ranNumber <= 3)
                {
                    _text.text = "BÌNH THƯỜNG";
                }
                else if(3< ranNumber && ranNumber <=6)
                {
                    _text.text = "HIẾM";
                }
                else if(ranNumber == 7)
                { 
                    _text.text = "HUYỀN THOẠI";
                }
                yield break;
            }
         
        }

 
        
    }
}
