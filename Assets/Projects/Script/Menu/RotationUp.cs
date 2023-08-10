using System;
using System.Collections;
using UnityEngine;

namespace Projects.Script.Menu
{
    public class RotationUp : MonoBehaviour
    {
        private void Start()
        {
            StartCoroutine(Rotation());

        }

        IEnumerator Rotation()
        {
            while (true)
            {
                transform.LeanRotate(new Vector3(0f, 0f, 5), 0.5f);
                yield return new  WaitForSeconds(0.7f);
                transform.LeanRotate(new Vector3(0f, 0f, 0), 0.5f);
                yield return new  WaitForSeconds(0.7f);
            }
        }
    }
}
