using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndGameManager : MonoBehaviour
{
    public float EndSceneLoadDelay = 3f;
    public float DelayBeforeFadeToBlack = 4f;
    public CanvasGroup EndGameFadeCanvasGroup;
    public string EndScene = "EndScreen";

    public bool GameIsEnding { get; private set; }
    float m_TimeLoadEndGameScene;
    string m_SceneToLoad;

    public Entity Player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        //check if player is dead

        if(Player.playerIsDead == true) {
            EndGame();
        }
        
        /*
        if (GameIsEnding)
        {
            float timeRatio = 1 - (m_TimeLoadEndGameScene - Time.time) / EndSceneLoadDelay;
            EndGameFadeCanvasGroup.alpha = timeRatio;


            // See if it's time to load the end scene (after the delay)
            if (Time.time >= m_TimeLoadEndGameScene)
            {
                SceneManager.LoadScene(m_SceneToLoad);
                GameIsEnding = false;
            }
        }*/
    }

    //void OnPlayerDeath(PlayerDeathEvent evt) => EndGame();

    public void EndGame()
    {

        Debug.Log("eding game");
        
        // unlocks the cursor before leaving the scene, to be able to click buttons
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        GameIsEnding = true;
        EndGameFadeCanvasGroup.gameObject.SetActive(true);

        m_SceneToLoad = EndScene;
        m_TimeLoadEndGameScene = Time.time + EndSceneLoadDelay + DelayBeforeFadeToBlack;
        SceneManager.LoadScene(m_SceneToLoad);
    }
}
