using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartLevel : MonoBehaviour
{
    public Transform playerLeft;
    public Transform playerRight;

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
        if (collision.gameObject.tag == "BallLeft")
        {
            collision.gameObject.transform.position = new Vector3(-4.4f, -0.66f, 0);
            collision.gameObject.GetComponent<BallMovementLeft>().StartOfBall();

            playerLeft.SendMessage("PunishmentLeft");
        }

        if (collision.gameObject.tag == "BallRight")
        {
            collision.gameObject.transform.position = new Vector3(4.4f, -0.66f, 0);
            collision.gameObject.GetComponent<BallMovementRight>().StartOfBall();

            playerRight.SendMessage("PunishmentRight");
        }
    }
}
