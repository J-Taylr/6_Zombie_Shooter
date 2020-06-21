using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] float fovOut;
    [SerializeField] float fovIn;


    private void Start()
    {
        fpsCamera.fieldOfView = fovOut;
    }

    private void Update()
    {
        PlayerZoom();
    }

    private void PlayerZoom()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            fpsCamera.fieldOfView = fovIn;
        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            fpsCamera.fieldOfView = fovOut;
        }
    }
}
