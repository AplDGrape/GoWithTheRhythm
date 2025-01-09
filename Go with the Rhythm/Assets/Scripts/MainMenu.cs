using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Go to Level Select scene
    public void PlayGame()
    {
        //Get Next Scene
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("LevelSelect");

    }

    //Quits the game
    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
