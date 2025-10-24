using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public bool playClicked = false;
    public void playGame()
    {
        Parallax.speed = 0.004f;
        PipeMoveScript.dist = PipeMoveScript.ogDist;
        SceneManager.LoadScene("mainGame");
        playClicked = true;
    }

    public void quitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

}

