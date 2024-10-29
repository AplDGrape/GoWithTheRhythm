using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        //Get Next Scene
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("LevelSelect");

    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
