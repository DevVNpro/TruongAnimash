using System;
using System.Collections;
using System.Collections.Generic;
using Projects.Script.PvP;
using Projects.Script.PvP.EnemyCard;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class AttackEnemy : MonoBehaviour
{
    public static bool IsPlayerTurn;


    private void Start()
    {
        IsPlayerTurn = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (IsPlayerTurn&& other.CompareTag("Enemy"))
        {
            IsPlayerTurn = false;
            Settrigger(other);
        }
    

        
    }

    public void Settrigger(Collider2D other)
    {
       
        int health = other.GetComponent<Card>().attack;
        int attack = transform.GetComponent<Card>().attack;
        if (attack >= health)
        {
           // StartCoroutine(other, health);
        }
        else
        {
            other.transform.Find("TextReceiver").GetComponentInChildren<ShowDamageReceiver>().StartShow(attack);
            health -= attack;
        }
 
        other.GetComponent<Card>().attack = health;
    }

    IEnumerator DeductAttack(GameObject other, int health)
    {
        other.transform.Find("TextReceiver").GetComponentInChildren<ShowDamageReceiver>().StartShow(health);
        health -= health;
        other.transform.LeanScale(new Vector3(0f, 0f), 1.3f);
        yield return  new WaitForSeconds(2f);
        //xu li tiep phan thoat ra khoi slot
        other.transform.SetParent(transform.root);
        
        
        
    }
}
