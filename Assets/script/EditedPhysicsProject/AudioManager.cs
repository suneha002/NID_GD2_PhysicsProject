using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [Header("Audio Sources")]
    public AudioSource musicSource; 
    public AudioSource sfxSource;  

    [Header("Music Clips")]
    public AudioClip backgroundMusic;
    public AudioClip gameOverMusic;

    [Header("SFX Clips")]
    public AudioClip startClick;
   [Header("Hit Sounds")]
public AudioClip normalHitSound;
public AudioClip penaltyHitSound;
void Start()
{
    PlayBackgroundMusic();
}


    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    // 🎵 BACKGROUND MUSIC
    public void PlayBackgroundMusic()
    {
        if (musicSource.clip == backgroundMusic && musicSource.isPlaying)
            return;

        musicSource.Stop();
        musicSource.clip = backgroundMusic;
        musicSource.loop = true;
        musicSource.Play();
    }

  
    public void PlayGameOverMusic()
    {
        musicSource.Stop();
        musicSource.clip = gameOverMusic;
        musicSource.loop = false;
        musicSource.Play();
    }

    
    public void PlayStartClick()
    {
        sfxSource.PlayOneShot(startClick);
    }

   
   public void PlayNormalHit()
{
    sfxSource.PlayOneShot(normalHitSound);
}

public void PlayPenaltyHit()
{
    sfxSource.PlayOneShot(penaltyHitSound);
}
}
