using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftBricksTotalControl : MonoBehaviour
{
    private float disabledBricksCount = 0;
    // 0 means moving towards left, 1 means moving towards right
    private float speedDirection = 0;
    public float moveSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > -4.9f && speedDirection == 0)
        {
            transform.Translate(new Vector3(moveSpeed * -0.0075f, 0, 0));
        }
        else if (transform.position.x <= -4.9f && speedDirection == 0)
        {
            speedDirection = 1;
        }
        else if (transform.position.x < -3.76f && speedDirection == 1)
        {
            transform.Translate(new Vector3(moveSpeed * 0.0075f, 0, 0));
        }
        else if (transform.position.x >= -3.76f && speedDirection == 1)
        {
            speedDirection = 0;
        }
    }

    public void DisabledCountIncrease()
    {
        disabledBricksCount += 1;
        Debug.Log(disabledBricksCount);
    }

    public void DisabledCountDecrease()
    {
        disabledBricksCount -= 1;
        Debug.Log(disabledBricksCount);
    }
}
