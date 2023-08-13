using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class AnimalSaveData
{
   public string name;
   public string imgname;
   public string key;


   public AnimalSaveData(string name1, string imgname1,string key1)
   {
      name = name1;
      imgname = imgname1;
      key = key1;
   }
}
