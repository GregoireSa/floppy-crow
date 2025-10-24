using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;
    public birdScript bird;

    // Start is called before the first frame update
    void Start() 
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        bird = GameObject.FindGameObjectWithTag("Player").GetComponent<birdScript>();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3 && bird.isAlive == true)
        {
            logic.addScore(1);
            if (Parallax.speed * Parallax.difficulty < 0.0135){
                Debug.Log("Before" + Parallax.speed.ToString());
                Parallax.speed *= Parallax.difficulty;
                Debug.Log("After" + Parallax.speed.ToString());
                PipeMoveScript.dist *= Parallax.difficulty;
            }
        }
    }
}