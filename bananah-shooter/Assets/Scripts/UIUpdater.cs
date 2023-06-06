using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIUpdater : MonoBehaviour
{
    public TextMeshProUGUI enemyInfo;
    public TextMeshProUGUI objectiveInfo;
    public TextMeshProUGUI interact;
    public RoundManager roundManager;

    // Start is called before the first frame update
    void Start()
    {
        HideInteract();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateEnemyInfo(int remainingEnemies)
    {
        enemyInfo.text = "Available Enemies: " + remainingEnemies + "\nRound: " + roundManager.round;
    }

    public void UpdateObjectiveNewRound()
    {
        objectiveInfo.text = "Kill all the monkeys!!!";
    }

    public void UpdateObjectiveAllEnemiesDestroyed()
    {
        objectiveInfo.text = "Ring the gong to start a new round";
    }

    public void ShowInteract(string infotext)
    {
        interact.text = infotext;
    }

    public void HideInteract()
    {
        interact.text = "";
    }
}
