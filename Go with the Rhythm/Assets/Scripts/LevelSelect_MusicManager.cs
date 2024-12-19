using UnityEngine;
using UnityEngine.Audio;

public class LevelSelect_MusicManager : MonoBehaviour
{
    public AudioMixerGroup audioMixer;

    //Reference to music Clips
    public LevelSelect_Music[] musics;

    private string currentMusicID = "Electric Therapy";
    public int CurrentSong = 0;
    public int SongCount;

    private void Awake()
    {
        //Create audiosources
        foreach (LevelSelect_Music m in musics)
        {
            m.source = gameObject.AddComponent<AudioSource>();
            m.source.clip = m.clip;
            m.source.outputAudioMixerGroup = audioMixer;
        }

        SongCount = musics.Length;
    }

    public void ChangeMusic(string newMusicID)
    {
        //Stop current music
        foreach (LevelSelect_Music m in musics)
        {
            if (m.musicID == currentMusicID)
            {
                m.source.Stop();
                break;
            }
        }


        //Change currentmusicID
        currentMusicID = newMusicID;

        //Play new music
        foreach (LevelSelect_Music m in musics)
        {
            if (m.musicID == currentMusicID)
            {
                m.source.Play();
                break;
            }
        }
    }

    public void NextSongCondition()
    {
        if (GameOverMenu.ETComplete)
        {
            NextSong();
        }
    }

    public void NextSong()
    {
        if (CurrentSong < SongCount)
        {
            //Stop current song
            musics[CurrentSong].source.Stop();
            //Go to next song
            CurrentSong++;
            //Play next song
            musics[CurrentSong].source.Play();
        }
        else if (CurrentSong >= SongCount)
        {
            musics[CurrentSong].source.Play();
        }
    }

    public void PreviousSong()
    {
        if (CurrentSong > 0)
        {
            //Stop current song
            musics[CurrentSong].source.Stop();
            //Go to previous song
            CurrentSong--;
            //Play previous song
            musics[CurrentSong].source.Play();
        }
        else if (CurrentSong <= 0)
        {
            musics[CurrentSong].source.Play();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        musics[0].source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
