using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LogicScript : MonoBehaviour
{
    public static int playerScore, finalScore, pb;
    public bool throughPipe;
    public TextMeshProUGUI scoreText;
    public GameObject bird,pipesp,pauseText;
    private bool isPaused = false;

    void Update()
    {
        throughPipe = false;
    }

    public void addScore(int scoreToAdd)
    {
        throughPipe = true;
        Parallax.speed *= Parallax.difficulty;
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void gameOver()
    {
        Parallax.speed = 0.004f;
        finalScore = playerScore;
        if (finalScore > PlayerPrefs.GetInt("pb",0)) PlayerPrefs.SetInt("pb",finalScore);
        playerScore = 0;
        SceneManager.LoadScene("gameOver");
    }

}
