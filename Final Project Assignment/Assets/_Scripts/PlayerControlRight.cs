using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlRight : MonoBehaviour
{
    public float speed = 1;
    public Transform ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > (0.25f + transform.localScale.x / 2))
        {
            transform.Translate(new Vector3(speed * -0.025f, 0, 0));
        }
        else if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < (8.48f - transform.localScale.x / 2))
        {
            transform.Translate(new Vector3(speed * 0.025f, 0, 0));
        }

        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < -1f)
        {
            transform.Translate(new Vector3(0, speed * 0.025f, 0));
        }
        else if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -4.43f)
        {
            transform.Translate(new Vector3(0, speed * -0.025f, 0));
        }

        if (Input.GetKey(KeyCode.RightShift))
        {
            ball.SendMessage("ResetBallPosition");
        }
    }

    public void PunishmentRight()
    {
        if (transform.localScale.x > 1)
        {
            transform.localScale += new Vector3(-0.1f, 0, 0);
        }
    }
}
