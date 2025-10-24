using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 0.1f;
    public float deadZone;
    public static Vector3 dist, ogDist;
    public GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera");
        ogDist = Vector3.left * moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        deadZone = cam.transform.position.x - 15f;
        dist = Vector3.left * moveSpeed;
        transform.position = transform.position + (dist) * Time.deltaTime;
        if (transform.position.x <= deadZone)
        {
            Destroy(gameObject);
        }
    }
}
