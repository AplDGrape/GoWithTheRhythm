using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    [SerializeField] public AudioMixer audioMixer;
    [SerializeField] private Slider musicSlider;

    private void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume"))
        {
            LoadVolume();
        }
        else
        {
            SetVolume();
        }
    }

    //Change volume
    public void SetVolume()
    {
        float volume = musicSlider.value;
        audioMixer.SetFloat("Volume", Mathf.Log10(volume)*20);
        PlayerPrefs.SetFloat("musicVolume", volume);
    }

    //Loads previous user selected value of colume
    private void LoadVolume()
    {
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");

        SetVolume();
    }
}
