using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] Camera fPCamera;
    [SerializeField] float range = 100f;
    [SerializeField] float weaponDamage = 30f;
    [SerializeField] ParticleSystem muzzleFlash;
    [SerializeField] GameObject hitVFX;
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        ProcessRaycast();
        PlayMuzzleFlash();

    }

    private void PlayMuzzleFlash()
    {
        muzzleFlash.Play();
    }

    private void ProcessRaycast()
    {
        RaycastHit hit;
        if (Physics.Raycast(fPCamera.transform.position, fPCamera.transform.forward, out hit, range))
        {
            
            
            EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();
            CreateHitImpact(hit);
            if (target == null) return;
            target.TakeDamage(weaponDamage);

        }
        else
        {
            return;
        }
    }

    private void CreateHitImpact(RaycastHit hit)
    {
       GameObject hitEffect = Instantiate(hitVFX, hit.point, Quaternion.LookRotation(hit.normal));
        Destroy(hitEffect, 0.1f);
    }
}
