using System;
using System.Collections;
using System.Collections.Generic;
using Projects.Script.PvP;
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

    private void Update()
    {
        Debug.Log(IsPlayerTurn);
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
            health -= health;
            other.transform.LeanScale(new Vector3(0f, 0f), 1.3f);
            //xu li tiep phan thoat ra khoi slot
            other.transform.SetParent(transform.root);
        }
        else
        {
             health -= attack;
        }
 
        other.GetComponent<Card>().attack = health;
    }
}
