using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundManager : MonoBehaviour
{

    public int round {get; private set;}
    public int availableEnemies {get; private set;}
    private int previousEnemies;

    // Start is called before the first frame update
    void Start()
    {
        round = 1;
        availableEnemies = 2;
        previousEnemies = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void newRound()
    {
        round++;
        //amount of available enemies per round is a fibonacci sequence
        int temp = availableEnemies;
        availableEnemies += previousEnemies;
        previousEnemies = temp;
    }
}
