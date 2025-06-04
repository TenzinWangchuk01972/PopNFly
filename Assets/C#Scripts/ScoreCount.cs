using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    private int points;
    public Text score;
    private int savedScore;
    public Text highScore;

    private void Start()
    {
        savedScore = PlayerPrefs.GetInt("HighScore");
        highScore.text = savedScore.ToString();
    }

    public void UpdatePlayerScore(int num)
    {
        points += num;
        AudioManager.instance.ScoreSound();
        score.text = points.ToString();

        if(points >  savedScore)
        {
            PlayerPrefs.SetInt("HighScore",points);

            savedScore = PlayerPrefs.GetInt("HighScore");
            highScore.text = savedScore.ToString(); 
        }
    }

}
