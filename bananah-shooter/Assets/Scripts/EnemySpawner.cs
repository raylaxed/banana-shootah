using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject Enemy;
    public GameObject SpawnLocation;
    public LayerMask WalkingPlane;

    public RoundManager roundManager;
    public UIUpdater uIUpdater;
    
    private int counter = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //only spawn enemies when you have more available
            if(counter < roundManager.availableEnemies && roundManager.round > 0)
            {
                Spawn();
            } else
            {
                Debug.LogWarning("No more enemies available.");
            }
            
        }
    }

    void Spawn()
    {
        //cast a ray downwards to check if you can spawn on ground
        if (Physics.Raycast(SpawnLocation.transform.position, Vector3.down, out RaycastHit hit, Mathf.Infinity, WalkingPlane))
        {
            GameObject newEnemy = Instantiate(Enemy, hit.point, Quaternion.Euler(0,0,0));
            counter++;

            //updates UI on screen
            uIUpdater.UpdateEnemyInfo(roundManager.availableEnemies -  counter);
        } else
        {
            Debug.LogWarning("Failed to spawn object. No ground detected.");
        }
    }

    public void NewRound()
    {
        counter = 0;
        uIUpdater.UpdateEnemyInfo(roundManager.availableEnemies);
    }
}
