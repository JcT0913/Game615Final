using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartLevel : MonoBehaviour
{
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            collision.gameObject.transform.position = new Vector3(-4.4f, -0.66f, 0);
            collision.gameObject.GetComponent<BallMovementLeft>().StartOfBall();

            player.SendMessage("Punishment");
        }
    }
}
