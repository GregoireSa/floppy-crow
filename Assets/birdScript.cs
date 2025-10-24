using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class birdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool isAlive = true;
    public float upperBound = 5;
    public float lowerBound = -5;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) == true || Input.GetMouseButtonDown(0) == true) && isAlive == true)
        {
            animator.SetTrigger("isJumping");
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
        if (transform.position.y >= upperBound || transform.position.y <= lowerBound)
        {
            logic.gameOver();
            isAlive = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        isAlive = false;
    }
}