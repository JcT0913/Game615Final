using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlLeft : MonoBehaviour
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
        //if (Input.GetKey(KeyCode.A) && transform.position.x > -7.66f)
        if (Input.GetKey(KeyCode.A) && transform.position.x > (-8.49f + transform.localScale.x / 2))
        {
            transform.Translate(new Vector3(speed * -0.025f, 0, 0));
        }
        //else if (Input.GetKey(KeyCode.D) && transform.position.x < -1.04f)
        else if (Input.GetKey(KeyCode.D) && transform.position.x < (-0.26f - transform.localScale.x / 2))
        {
            transform.Translate(new Vector3(speed * 0.025f, 0, 0));
        }

        if (Input.GetKey(KeyCode.W) && transform.position.y < -1f)
        {
            transform.Translate(new Vector3(0, speed * 0.025f, 0));
        }
        else if (Input.GetKey(KeyCode.S) && transform.position.y > -4.43f)
        {
            transform.Translate(new Vector3(0, speed * -0.025f, 0));
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            ball.SendMessage("ResetBallPosition");
        }
    }

    public void PunishmentLeft()
    {
        if (transform.localScale.x > 1)
        {
            transform.localScale += new Vector3(-0.1f, 0, 0);
        }
    }
}
