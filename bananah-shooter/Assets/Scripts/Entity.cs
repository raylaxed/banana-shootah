using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{

    public float StartingHealth;
    public bool playerIsDead;
    private float health;
    public ObjectiveManager ObjectiveManager;
    public GameObject particleSystem;

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
                } else
                {
                    //tells the objective Manager that an Enemy has been detroyed so we can keep track if the round should be over or not
                    ObjectiveManager.EnemyDestroyed();
                    // Spawns Particle System that destroys itself after the particles are all done doing their job
                    Instantiate(particleSystem, transform.position, Quaternion.identity);
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
