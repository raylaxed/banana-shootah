using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundManager : MonoBehaviour
{

    public int round {get; private set;}
    public int availableEnemies {get; private set;}
    private int previousEnemies;

    public SkyBoxChanger SkyBoxChanger;
    public EnemySpawner EnemySpawner;
    public UIUpdater uIUpdater;

    // Start is called before the first frame update
    void Start()
    {
        round = 0;
        availableEnemies = 1;
        previousEnemies = 1;
    }

    public void NewRound()
    {
        //amount of available enemies per round is a fibonacci sequence
        int temp = availableEnemies;
        availableEnemies += previousEnemies;
        previousEnemies = temp;

        if (round > 0)
        {
            SkyBoxChanger.ChangeSkybox();
        }
        round++;
        
        EnemySpawner.NewRound();
        uIUpdater.UpdateObjectiveNewRound();
    }
}
