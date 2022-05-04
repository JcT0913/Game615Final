using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BricksTotalControllerRight : MonoBehaviour
{
    public float disabledBricksCountRight = 0;
    // 0 means moving towards left, 1 means moving towards right
    private float speedDirection = 0;
    public float moveSpeed = 0.5f;

    public List<GameObject> rightBricks = new List<GameObject>();
    public List<GameObject> disabledBricksRight = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (disabledBricksCountRight > 0)
        {
            foreach (GameObject go in rightBricks)
            {
                if (!go.activeSelf && !disabledBricksRight.Contains(go))
                {
                    disabledBricksRight.Add(go);
                }
            }
        }

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
        //Debug.Log(disabledBricksCountRight);
    }

    public void DisabledCountDecrease()
    {
        disabledBricksCountRight -= 1;
        //Debug.Log(disabledBricksCountRight);
    }

    public void NewBrick()
    {
        if (disabledBricksCountRight > 0)
        {
            //foreach (GameObject go in rightBricks)
            //{
            //    if (!go.activeSelf && !disabledBricksRight.Contains(go))
            //    {
            //        disabledBricksRight.Add(go);
            //    }
            //}

            int selectedBrickNumber = (int)Random.Range(0, disabledBricksCountRight);
            disabledBricksRight[selectedBrickNumber].SetActive(true);
            disabledBricksRight.RemoveAt(selectedBrickNumber);
            //disabledBricksRight.Clear();
            DisabledCountDecrease();
        }
    }
}
