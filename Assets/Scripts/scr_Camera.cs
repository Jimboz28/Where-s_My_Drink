﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Camera : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public float joySensitivity = 100f;

    public Transform playerBody;

    float xRotation = 0f;
    float yRotation = 0f;

    // Start is called before the first frame update
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
       
       float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
       float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
       
       
       float joystickX = Input.GetAxis ("Joystick X") * joySensitivity * Time.deltaTime;
       float joystickY = Input.GetAxis("Joystick Y") * joySensitivity * Time.deltaTime;

       xRotation -= mouseY;
       yRotation += mouseX;
       
       xRotation -= joystickY;
       yRotation += joystickX;

       xRotation = Mathf.Clamp(xRotation, -90f, 90f);
       transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
       playerBody.Rotate(Vector3.up * mouseX);

    }
}
