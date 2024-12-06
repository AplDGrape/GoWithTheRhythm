using UnityEngine;

[System.Serializable]
public class LevelSelect_Music
{
    public string musicID;
    public AudioClip clip;
    [HideInInspector] public AudioSource source;
}
