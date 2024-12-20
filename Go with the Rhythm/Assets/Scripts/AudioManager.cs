using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public float timeStart;
    public static float timescore;
    public static bool SongEnd = false;

    [Header("----------Audio Source----------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("---------Audio Clip----------")]
    public AudioClip backgroundAudio;

    // Start is called before the first frame update
    void Start()
    {
        musicSource.clip = backgroundAudio;
        musicSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        timeStart += Time.deltaTime;

        if (PauseMenu.GameisPaused == true)
        {
            if (musicSource.isPlaying)
            {

                musicSource.Pause();
            }
        }
        else
        {
            if (!musicSource.isPlaying)
            {
                Time.timeScale = 1f;
                musicSource.Play();
            }
        }

        if (timeStart >= musicSource.clip.length || PlayerMovement.alive == false)
        {
            SongEnd = false;
            //Debug.Log("End");
            musicSource.Stop();
        }
        else
        {
            if (PauseMenu.GameisPaused == true)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
            SongEnd = true;
        }
        timescore = timeStart;

        Debug.Log(musicSource.time);
    }
}
