using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
   public static AudioManager instance;

    public AudioSource eventSound;
    public AudioClip jumpsound;
    public AudioClip deadSound;
    public AudioClip buttonSound;
    public AudioClip score;
    public AudioClip wallHit;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    public void playerSound(AudioClip sound)
    {
        eventSound.PlayOneShot(sound);
    }

    public void JumpSound()
    {
        playerSound(jumpsound); 
    }

    public void DeadSound()
    {
        playerSound(deadSound);
    }
    public void HitWall()
    {
        playerSound(wallHit);
    }

    public void ButtonSound()
    {
        playerSound(buttonSound);   
    }

    public void ScoreSound()
    {
        playerSound(score);
    }
        
}
