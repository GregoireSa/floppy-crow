using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transitionScript : MonoBehaviour
{
    public MainMenuScript mainMenu;
    public Animator anim;
    public float transitionTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        mainMenu = GameObject.FindGameObjectWithTag("Menu").GetComponent<MainMenuScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mainMenu.playClicked == true)
        {
            crossfade_transition("mainGame");
        }
    }
    
    void crossfade_transition(string  sceneName)
    {
        StartCoroutine(transition(sceneName));
    }

    IEnumerator transition(string transitionName)
    {
        anim.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(transitionName);
    }
}
