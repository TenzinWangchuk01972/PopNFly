using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public Sprite soundOn;
    public Sprite soundOff;
    public GameObject soundBT;

    public Sprite musicOn;
    public Sprite musicOff;
    public GameObject musicBT;

    public Sprite vibrationOn;
    public Sprite vibrationOff;
    public GameObject vibrationBT;

    public void Sound()
    {
        AudioManager.instance.ButtonSound();
        if (soundBT.GetComponent<Image>().sprite == soundOn)
        {
            soundBT.GetComponent<Image>().sprite = soundOff;
            AudioManager.instance.eventSound.volume = 0;
        }
        else
        {
            soundBT.GetComponent <Image>().sprite = soundOn;
            AudioManager.instance.eventSound.volume = 1;
        }
    }

    public void Music()
    {
        AudioManager.instance.ButtonSound();
        if (musicBT.GetComponent<Image>().sprite == musicOn)
        {
            musicBT.GetComponent<Image>().sprite = musicOff;
            AudioManager.instance.eventSound.volume = 0;
        }
        else
        {
            musicBT.GetComponent <Image>().sprite = musicOn;
        }
    }

    public void Vibration()
    {
        AudioManager.instance.ButtonSound();    
        if (vibrationBT.GetComponent<Image>().sprite == vibrationOn)
        {
            vibrationBT.GetComponent <Image>().sprite = vibrationOff;
            AudioManager.instance.eventSound .volume = 0;
        }
        else
        {
            vibrationBT.GetComponent<Image>().sprite = vibrationOn;
        }
    }

}


