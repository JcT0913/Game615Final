using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BricksTotalControllerRight : MonoBehaviour
{
    public float disabledBricksCountRight = 0;
    // 0 means moving towards left, 1 means moving towards right
    private float speedDirection = 0;
    public float moveSpeed = 1;

    public List<Transform> rightBricks = new List<Transform>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (disabledBricksCountRight < rightBricks.Count)
        {
            if (transform.position.x > 3.9f && speedDirection == 0)
            {
                transform.Translate(new Vector3(moveSpeed * -0.0075f, 0, 0));
            }
            else if (transform.position.x <= 3.9f && speedDirection == 0)
            {
                speedDirection = 1;
            }
            else if (transform.position.x < 4.9f && speedDirection == 1)
            {
                transform.Translate(new Vector3(moveSpeed * 0.0075f, 0, 0));
            }
            else if (transform.position.x >= 4.9f && speedDirection == 1)
            {
                speedDirection = 0;
            }
        }
    }

    public void DisabledCountIncrease()
    {
        disabledBricksCountRight += 1;
        Debug.Log(disabledBricksCountRight);
    }

    public void DisabledCountDecrease()
    {
        disabledBricksCountRight -= 1;
        Debug.Log(disabledBricksCountRight);
    }
}
