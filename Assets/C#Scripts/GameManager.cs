using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject home;
    public GameObject setting;
    public GameObject pause;
    public GameObject game;
    public GameObject close;
    public GameObject musicOn;
    public GameObject musicOff;
    public GameObject soundOn;
    public GameObject soundOff;
    public GameObject vibrationOn;
    public GameObject vibrationOff;
    public GameObject basketH;
    public GameObject restart;

    public static bool isRestarting;

    public void Start()
    {
        if(isRestarting == true)
        {
            home.SetActive(false);
            setting.SetActive(false);
            pause.SetActive(false);
            game.SetActive(true);
        }
        else
        {
            home.SetActive(true);
            setting.SetActive(false);
            pause.SetActive(false);
            game.SetActive(false);
        }
           
    }

    public void StartGame()
    {
        home.SetActive(false);
        game.SetActive(true );
        pause.SetActive(false);
        basketH.SetActive(true);
        Time.timeScale = 1;
        isRestarting = true;    
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void PauseButton()
    {
        pause.SetActive(true);
        Time.timeScale = 0;
    }

    public void SettingPop()
    {

        game.SetActive(false);
        setting.SetActive(true);
        pause.SetActive(false);
        home.SetActive(false);
    }

    public void Home()
    {
        isRestarting = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        home.SetActive(true);
        game.SetActive(false);
    }

    public void resume()
    { 
        pause.SetActive(false);
        Time.timeScale = 1;
    }

    public void MusicOn()
    {
        musicOn.SetActive(false);
        musicOff.SetActive(true);
    }
    public void MusicOff()
    {
        musicOff.SetActive(false);
        musicOn.SetActive(true);
    }

    public void SoundOn()
    {
        soundOn.SetActive(false);
        soundOff.SetActive(true);
    }
    public void SoundOff()
    {
        soundOff.SetActive(false);
        soundOn.SetActive(true);
    }

    public void VibrationoN()
    {
        vibrationOn.SetActive(false);
        vibrationOff.SetActive(true);
    }
    public void VibrationOff()
    {
        vibrationOff.SetActive(false);
        vibrationOn.SetActive(true);
    }

    public void Close()
    {
        setting.SetActive(false);
        home.SetActive(true) ;
    }

    public void RestartBT()
    {
        Time.timeScale = 1;
        isRestarting = true;
        var sc = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sc);
    }
    
}    


