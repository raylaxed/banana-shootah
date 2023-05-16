using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealtHandler : MonoBehaviour
{
    // Start is called before the first frame update

    float displayHealth;
    public GameObject[] hearts;
     

    void Start()
    {
        Entity playerEntity = GameObject.Find("Player").GetComponent<Entity>();
         Debug.Log(playerEntity);
        displayHealth = playerEntity.Health;
        Debug.Log(displayHealth);
       
        
    }

    // Update is called once per frame
    void Update()
    {
        Entity playerEntity = GameObject.Find("Player").GetComponent<Entity>();
        displayHealth = playerEntity.Health;
        Debug.Log(displayHealth);

        for(int i = 0 ;i< displayHealth; i++  ){
            hearts[i].SetActive(true);
        }
          // Toggle the visibility of the hearts when the "Toggle" key is pressed
        
    }
     
}
