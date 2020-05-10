using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControler : MonoBehaviour
{
    //Be sure every scene is in the BUILD, otherwise the script wont work.
    public string game;
    public string controlMenu;
    public string mainMenu;

    public void MainMenu()
    {
        //A pan will also be added here.
        SceneManager.LoadScene(mainMenu);

    }

    public void Restart()
    {
        SceneManager.LoadScene(game);
    }

    public void Play()
    {
        //A zooming in will be added later.
        SceneManager.LoadScene(game);

    }

    public void Exit()
    {

        Application.Quit();

    }

    public void ControlMenu()
    {
        //For flavor, a quick pan will be added before the scene properly changes.
        SceneManager.LoadScene(controlMenu);

    }

}
