using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class WeaponZoom : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] Camera fpsCamera;
    [SerializeField] RigidbodyFirstPersonController fpsController;

    [Header("Values")]
    [SerializeField] float fovOut;
    [SerializeField] float fovIn;
    [SerializeField] float zoomOutSensitivity = 2f;
    [SerializeField] float zoomInSensitivity = 0.5f;
    public bool zoomedIn = false;
    

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
            ZoomIn();

        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            ZoomOut();

        }
    }

    private void ZoomOut()
    {
        fpsCamera.fieldOfView = fovOut;
        fpsController.mouseLook.XSensitivity = zoomOutSensitivity;
        fpsController.mouseLook.YSensitivity = zoomOutSensitivity;
    }

    private void ZoomIn()
    {
        fpsCamera.fieldOfView = fovIn;
        fpsController.mouseLook.XSensitivity = zoomInSensitivity;
        fpsController.mouseLook.YSensitivity = zoomInSensitivity;
    }

    private void OnDisable()
    {
        ZoomOut();    
    }

}
