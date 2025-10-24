using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class Parallax : MonoBehaviour
{
    public static float length, startPos, difficulty, speed;
    [SerializeField] private float parallaxEffect;

    private GameObject cam;
    private GameObject spawner;
    private GameObject birdie;
    private GameObject particles;

    void Start() 
    {  

        cam = GameObject.Find("Main Camera");
        spawner = GameObject.Find("Pipe Spawner");
        birdie = GameObject.Find("Bird");
        particles = GameObject.Find("Particle System");

        speed = 0.004f;
        difficulty = 1.4f;
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        if ((LogicScript.playerScore % 5 == 0) && (speed * difficulty < 0.03f) && (LogicScript.throughPipe == true)){
                speed *= difficulty;
                PipeMoveScript.distance *= difficulty;
            }

        float oppDistance = (cam.transform.position.x * (1-parallaxEffect));
        float distance = (cam.transform.position.x * parallaxEffect);

        transform.position = new Vector3(startPos + distance, transform.position.y, transform.position.z);
        cam.transform.position = new Vector3(cam.transform.position.x + speed, cam.transform.position.y, cam.transform.position.z);
        spawner.transform.position = new Vector3(spawner.transform.position.x + speed, spawner.transform.position.y, spawner.transform.position.z);
        birdie.transform.position = new Vector3(birdie.transform.position.x + speed, birdie.transform.position.y, birdie.transform.position.z);
        particles.transform.position = new Vector3(particles.transform.position.x + speed, particles.transform.position.y, particles.transform.position.z);

        if (oppDistance > startPos + length/2) startPos += length;
        else if (oppDistance < startPos - length/2) startPos -= length;
    }
}
