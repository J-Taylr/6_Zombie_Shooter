using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float playerHealth = 100f;
    
    
    public void PlayerTakeDamage(float enemyDamage)
    {
        playerHealth -= enemyDamage;
        print(playerHealth);
        if (playerHealth <= Mathf.Epsilon)
        {
            GetComponent<DeathHandler>().HandleDeath();       
        }
    }
  
}


