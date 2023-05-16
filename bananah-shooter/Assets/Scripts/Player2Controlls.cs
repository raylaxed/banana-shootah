using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controlls : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
       if (Input.GetKey(KeyCode.LeftArrow))
     {
         transform.position += Vector3.left * moveSpeed * Time.deltaTime;
     }
     if (Input.GetKey(KeyCode.RightArrow))
     {
         transform.position += Vector3.right * moveSpeed * Time.deltaTime;
     }
     if (Input.GetKey(KeyCode.UpArrow))
     {
         transform.position += Vector3.up * moveSpeed* Time.deltaTime;
     }
     if (Input.GetKey(KeyCode.DownArrow))
     {
         transform.position += Vector3.down * moveSpeed * Time.deltaTime;
     }
    }
}