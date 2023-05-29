using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveManager : MonoBehaviour
{
    public RoundManager RoundManager;
    private int destroyedEnemies;
    
    // Start is called before the first frame update
    void Start()
    {
        destroyedEnemies = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void NewRound()
    {
        destroyedEnemies = 0;
        RoundManager.NewRound();
    }

    // EnemyDestroyed has to be called from the Entity script when an enemy dies
    public void EnemyDestroyed()
    {
        destroyedEnemies++;

        if(destroyedEnemies >= RoundManager.availableEnemies)
        {
            NewRound();
        }
    }
}
