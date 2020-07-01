using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;
    [SerializeField] Animator animator;

    bool isDead = false;
    
    public bool IsDead()
    {
        return isDead;
    }

    //create public method which reduces hitpoints by amount of damage (get component weapon)

    public void TakeDamage(float weaponDamage)
    {
        BroadcastMessage("OnDamageTaken");
        hitPoints -= weaponDamage; 
        if (hitPoints <= 0)
        {
            Die();
            animator.SetBool("IsDead", true);
            BroadcastMessage("DisableAI");
        }
    }

    private void Die()
    {
        if (isDead) { return; }
        isDead = true;
        GetComponent<Animator>().SetTrigger("isDead");
        
    }
}
