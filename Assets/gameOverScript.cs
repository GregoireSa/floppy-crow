using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class gameOverScript : MonoBehaviour
{
    public TextMeshProUGUI display_score, display_pb;
    
    public void Start()
    {
    }
    
    public void Update()
    {

        display_score.text = "Score: " + LogicScript.finalScore.ToString();
        display_pb.text = "Highscore: " + PlayerPrefs.GetInt("pb").ToString();

        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("mainGame");
        }
    }

    public void backToMenu()
    {
        SceneManager.LoadScene("menu");
    }
    public void restart()
    {
        Parallax.speed = 0.004f;
        PipeMoveScript.dist = PipeMoveScript.ogDist;
        SceneManager.LoadScene("mainGame");
    }
}
