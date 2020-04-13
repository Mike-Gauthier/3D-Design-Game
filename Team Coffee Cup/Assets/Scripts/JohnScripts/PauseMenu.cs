using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // 
    public static bool pause = false;
    public GameObject pauseMenu;
    public string mainMenu;
    // 
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape)) //The current button to pause the game is Escape. This can be changed later.
        {
            if (pause == true)
            {
                Resume();
            }
            else
            {
                PauseGame();
            }
        }
    }

    
    void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        pause = true;
    }

    //The below functions will be assigned to buttons in the actual pause menu.
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        pause = false;
    }
    public void ReturnToMenu()
    {
        SceneManager.LoadScene(mainMenu);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
