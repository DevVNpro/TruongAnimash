using System;
using System.Collections;
using System.Collections.Generic;
using Projects.Script.PvP;
using UnityEngine;

public class AttackPlayer : MonoBehaviour
{
   public static bool IsEnemeTurn;

   private void Start()
   {
      IsEnemeTurn = false;
   }

   private void OnTriggerEnter2D(Collider2D other)
   {
      if (other.CompareTag("Player1")&&IsEnemeTurn)
      {
         IsEnemeTurn = false;
         Settrigger(other);
      }    
      if (other.CompareTag("Player2")&&IsEnemeTurn)
      {
         IsEnemeTurn = false;
         Settrigger(other);
      }      

      if (other.CompareTag("Player3")&&IsEnemeTurn)
      {
         IsEnemeTurn = false;
         Settrigger(other);
      }
   }

   private void Settrigger(Collider2D other)
   {
      int health = other.GetComponent<Card>().attack;
      int attack = transform.GetComponent<Card>().attack;
      if (attack >= health)
      {
         health -= health;
         other.transform.LeanScale(new Vector3(0f, 0f), 1.3f);
         other.transform.SetParent(transform.root);
      }
      else
      {
         health -= attack;
      }
      other.GetComponent<Card>().attack = health;
   }
   
}
