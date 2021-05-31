using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class StayInTheZoneGameManager : MonoBehaviour
{
    public GameObject gameOverScreen;
    public TextMeshProUGUI scoreText;

    private int score = 0;
    private bool gameEnded = false;

    // Start is called before the first frame update
    void Start()
    {
        ChangeScore(0);
        gameEnded = false;
        gameOverScreen.SetActive(false);
        GetComponent<TimerScript>()?.StartTimer();
    }

    public void ChangeScore(int value)
    {
        if(gameEnded)
        {
            return;
        }

        score += value;
        scoreText.text = $"Score: {score}";
    }

    public void GameEnd()
    {
        gameEnded = true;
        gameOverScreen.SetActive(true);
    }


}
