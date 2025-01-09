using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameisPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameisPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    //Resumes Game scene
    public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
    }

    //Pause game scene
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;
    }

    //Go to Main Menu
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        GameisPaused = false;
        SceneManager.LoadScene("MainMenu");
    }

    //Quit the game
    public void QuitGame()
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    }
}
