 using System;
 using UnityEngine;
 using System.Collections;
 
 public class MouseLook : MonoBehaviour
 {
     public float mouseSensitivity = 400.0f;
     public float clampAngle = 80.0f;
 
     private float rotY = 0.0f; // rotation around the up/y axis
     private float rotX = 0.0f; // rotation around the right/x axis

    public PauseMenuScript pauseMenu;

     void Start ()
     {
         Vector3 rot = transform.localRotation.eulerAngles;
         rotY = rot.y;
         rotX = rot.x;
     }
 
     void Update ()
     {
         float mouseX = Input.GetAxis("Mouse X");
         float mouseY = Input.GetAxis("Mouse Y");
 
         rotY += mouseX * mouseSensitivity * Time.deltaTime;
         rotX += mouseY * mouseSensitivity * Time.deltaTime;
 
         rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);
 
         Quaternion localRotation = Quaternion.Euler(rotX, rotY, 0.0f);
         transform.rotation = localRotation;
     }
 }