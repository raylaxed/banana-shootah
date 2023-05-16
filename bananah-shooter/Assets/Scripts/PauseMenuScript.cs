using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
   
    public GameObject pauseMenu;
    public bool isPaused;




    //GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        Cursor.visible = false;
     //   Player = GameObject.find("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(isPaused){
                ResumeGame();
            }
            else{
                PauseGame();
            }

        }
    }

    public void PauseGame(){
        pauseMenu.SetActive(true);
        Cursor.visible = true;
        Time.timeScale = 0f;
        isPaused = true;
        //Player.PlayerInputHandler.Pause;

    }

    public void ResumeGame() {
        pauseMenu.SetActive(false);
        Cursor.visible = false;
        Time.timeScale = 1f;
        isPaused = false;
        //Player.PlayerInputHandler.Resume();
    }
    public void GoToMainMenu(){
        Time.timeScale = 1f;
       SceneManager.LoadScene("MainMenu");


    }

    public void QuitGame(){
        Application.Quit();
    }


}
