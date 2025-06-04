using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GameOverManager : MonoBehaviour
{
    private Rigidbody2D playerRB;
    public GameObject gameOver;
    [SerializeField] private ScoreCount points;
    private bool isPerfectScore;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Obstical"))
        {
            AudioManager.instance.DeadSound();
            Debug.Log("GameOver");
            gameObject.SetActive(false);
            gameOver.SetActive(true);
        }
        if (col.gameObject.CompareTag("Basket"))
        {
            isPerfectScore = false;
        }
    }
    private void Start()
    {
        playerRB = gameObject.GetComponent<Rigidbody2D>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(playerRB.velocity.y < 0)
        {//if player dunks from above

            collision.transform.parent.GetComponent<BoxCollider2D>().enabled = false;
            collision.transform.GetComponent<BoxCollider2D>().enabled = false;

            if (isPerfectScore == false)
            {
                points.UpdatePlayerScore(1);
            }
            else
            {
                points.UpdatePlayerScore(2);
            }
            isPerfectScore = true;   
        }

        else
        {
            Debug.Log("GameOver");
            gameObject.SetActive(false);
            AudioManager.instance.DeadSound();
            gameOver.SetActive(true);
        }
    }
}


