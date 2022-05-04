using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        StartOfBall();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartOfBall()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        float x = Random.Range(-5f, 5f);
        float y = Random.Range(-10f, -5f);

        Vector3 force = new Vector3(x, y, 0);

        rigidbody.velocity = new Vector3(0, 0, 0);
        rigidbody.AddForce(force.normalized * speed);
    }

    public void ResetBallPosition()
    {
        transform.position = new Vector3(-4.4f, -0.66f, 0);
        // call StartOfBall() here will make speed of ball increases
        //StartOfBall();
    }
}
