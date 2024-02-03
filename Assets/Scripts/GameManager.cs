using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    int score;
    int smashScore = 0;
    public GameObject winText;
    public GameObject restartButton;
    public TextMeshProUGUI scoreText;
    public GameObject gameStartUI;

    private void Awake() 
    {
        instance = this;
    }

    public void GameStart()
    {
        gameStartUI.SetActive(false);
        scoreText.gameObject.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("SaveBall");
    }

    public void ScoreUp()
    {
        score ++;
        scoreText.text = score.ToString();
    }

    public void SmashScoreUp()
    {
        smashScore ++;
        if(smashScore >= 4)
        {
            Win();
        }
    }

    void Win()
    {
        winText.SetActive(true);
        restartButton.SetActive(true);
    }

    public void SmashRestart()
    {
        SceneManager.LoadScene("BallSmash");
    }
}
