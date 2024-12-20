using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class LevelSelect_MusicManager : MonoBehaviour
{
    public AudioMixerGroup audioMixer;

    //Reference to music Clips
    public LevelSelect_Music[] musics;

    public TextMeshProUGUI titleText;

    private string currentMusicID = "Electric Therapy";
    public int CurrentSong = 0;
    public int SongCount;

    //Difficulty rating
    public GameObject[] starsDiff;
    public int difficultyRating;

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
        titleText.text = musics[CurrentSong].musicID;

        CurDiff();

        Difficulty(difficultyRating);
    }

    public void CurDiff()
    {
        if (CurrentSong == 0)
        {
            difficultyRating = 2;
        }
        else if (CurrentSong == 1)
        {
            difficultyRating = 3;
        }
        else if (CurrentSong == 2)
        {
            difficultyRating = 1;
        }
    }

    public void Difficulty(int difficulty)
    {
        if (difficulty == 1)
        {
            starsDiff[0].SetActive(true);

            starsDiff[1].SetActive(false);
            starsDiff[2].SetActive(false);
            starsDiff[3].SetActive(false);
            starsDiff[4].SetActive(false);
        }
        else if (difficulty == 2)
        {
            starsDiff[1].SetActive(true);

            starsDiff[0].SetActive(false);
            starsDiff[2].SetActive(false);
            starsDiff[3].SetActive(false);
            starsDiff[4].SetActive(false);
        }
        else if (difficulty == 3)
        {
            starsDiff[2].SetActive(true);

            starsDiff[0].SetActive(false);
            starsDiff[1].SetActive(false);
            starsDiff[3].SetActive(false);
            starsDiff[4].SetActive(false);
        }
        else if (difficulty == 4)
        {
            starsDiff[3].SetActive(true);

            starsDiff[0].SetActive(false);
            starsDiff[1].SetActive(false);
            starsDiff[2].SetActive(false);
            starsDiff[4].SetActive(false);
        }
        else if (difficulty == 5)
        {
            starsDiff[4].SetActive(true);

            starsDiff[0].SetActive(false);
            starsDiff[1].SetActive(false);
            starsDiff[2].SetActive(false);
            starsDiff[3].SetActive(false);
        }
    }
}
