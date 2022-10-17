using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    /// <summary>
    /// Awake is called before Start
    /// </summary>
    private void Awake()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }

    /// <summary>
    /// Loads th first level of the game.
    /// </summary>
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }


    /// <summary>
    /// Quit the game to the desktop
    /// </summary>
    public void QuittoDesktop()
    {
        Application.Quit();
    }
}
