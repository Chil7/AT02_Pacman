using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuHUD : MonoBehaviour
{
    [Tooltip("A reference to the pause menu game object in the UI for the scene.")]
    [SerializeField] private GameObject pauseMenu;

    //enables cursor on screen
    public bool CursorEnabled
    {
        set
        {
            Cursor.visible = value;
            if(value == true)
            {
                Cursor.lockState = CursorLockMode.Confined;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }

    //toggles Pause Menu off if its active at Start
    void Start()
    {
        if(pauseMenu.activeSelf == true)
        {
            TogglePauseMenu();
        }
    }

    //toggles on and off pause menu
    public bool TogglePauseMenu()
    {
        pauseMenu.SetActive(!pauseMenu.activeSelf);
        CursorEnabled = pauseMenu.activeSelf;
        return pauseMenu.activeSelf;
    }
}
