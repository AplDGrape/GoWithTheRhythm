using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameOverMenu : MonoBehaviour
{
    public static bool GameisOver = false;
    public GameObject GameOverUI;

    public TextMeshProUGUI scoreText;

    public GameObject[] stars;

    //Level is complete bool
    public static bool ETComplete = false;

    // Update is called once per frame
    void Update()
    {
        GameisOver = AudioManager.SongEnd;
        if (GameisOver)
        {
            Resume();
        }
        else
        {
            GameOver();
        }
    }

    //Resumes game after restart
    public void Resume()
    {
        GameOverUI.SetActive(false);
        Time.timeScale = 1f;
        GameisOver = false;
    }

    //Game over screen
    public void GameOver()
    {
        GameOverUI.SetActive(true);

        float points = 0.0f;
        points = AudioManager.timescore;
        Setup(points);

        Time.timeScale = 0f;
        //AudioManager.SongEnd = true;
        LevelSelectStatus();
    }

    //Restarts the game/round
    public void Restart()
    {
        GameOverUI.SetActive(false);
        AudioManager.SongEnd = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("ElectricTherapy");
    }

    //Go to main menu
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        GameOverUI.SetActive(false);
        //AudioManager.SongEnd = true;
        SceneManager.LoadScene("MainMenu");
    }

    void LevelSelectStatus()
    {
        ETComplete = true;
    }

    //Set ups the scores/stars
    public void Setup(float score)
    {
        //gameObject.SetActive(true);
        scoreText.text = score.ToString() + " Points";

        //Star System
        if (score >= 21 && score <= 55)
        {
            stars[0].SetActive(true);
        }
        else if (score >= 56 && score <= 110)
        {
            stars[0].SetActive(true);
            stars[1].SetActive(true);
        }
        else if (score >= 111)
        {
            stars[0].SetActive(true);
            stars[1].SetActive(true);
            stars[2].SetActive(true);
        }
    }
}
