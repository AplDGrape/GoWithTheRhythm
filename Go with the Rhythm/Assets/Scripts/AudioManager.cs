using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
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
    }
}
