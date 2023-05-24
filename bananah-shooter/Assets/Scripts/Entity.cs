using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{

    [SerializeField] public float StartingHealth;
    [SerializeField] public bool playerIsDead;
    private float health;

    public float Health{
        get 
        {
            return health;
        }
        set {
            
            health = value;
            Debug.Log(health);

            if(health <= 0f){
                if (gameObject.CompareTag("Player"))
                {
                    playerIsDead = true;
                    GameObject gameManager = GameObject.Find("GameManager");
                  //  gameManager.GetComponent<EndGameManager>().EndGame();
                    // Handle player death
                    Debug.Log("Player died!");
                }
                Destroy(gameObject);
            }

        }


    }
    // Start is called before the first frame update
    void Start()
    {
        playerIsDead = false;
        Health = StartingHealth;
    }

}
