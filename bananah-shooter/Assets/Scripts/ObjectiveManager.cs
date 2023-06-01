using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveManager : MonoBehaviour
{
    public RoundManager roundManager;
    public Gong gong;
    private int destroyedEnemies;
    
    // Start is called before the first frame update
    void Start()
    {
        destroyedEnemies = 0;
    }

    // EnemyDestroyed has to be called from the Entity script when an enemy dies
    public void EnemyDestroyed()
    {
        destroyedEnemies++;

        if(destroyedEnemies >= roundManager.availableEnemies)
        {
            destroyedEnemies = 0;
            gong.MakeInteractable();
        }
    }
}
