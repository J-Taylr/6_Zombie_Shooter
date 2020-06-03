using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;
    
    

    //create public method which reduces hitpoints by amount of damage (get component weapon)

    public void TakeDamage(float weaponDamage)
    {
        hitPoints -= weaponDamage; 
        if (hitPoints <= 0)
        {

            Destroy(gameObject);
        }
    }
}
