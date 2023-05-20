using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controlls : MonoBehaviour
{
    public float moveSpeed = 20f;

    void Update()
    {
       if (Input.GetKey(KeyCode.LeftArrow) && transform.position.z < 58)
     {
         transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
     }
     if (Input.GetKey(KeyCode.RightArrow) && transform.position.z > 24)
     {
        transform.position += Vector3.back * moveSpeed * Time.deltaTime;
     }
     if (Input.GetKey(KeyCode.UpArrow) && transform.position.x < 34)
     {
         transform.position += Vector3.right * moveSpeed* Time.deltaTime;
     }
     if (Input.GetKey(KeyCode.DownArrow) && transform.position.x > -4.5)
     {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
     }
    }
}