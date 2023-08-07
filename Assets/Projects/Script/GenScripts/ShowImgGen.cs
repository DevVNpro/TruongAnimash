using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowImgGen : MonoBehaviour
{
   private void Start()
   {
      transform.localScale = new Vector3(0f, 0f, 0f);

      transform.LeanScale(new Vector3(1.3f, 1.3f), 1.2f);
   }
}
