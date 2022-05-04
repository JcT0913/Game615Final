using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BricksTotalControllerLeft : MonoBehaviour
{
    public float disabledBricksCountLeft = 0;
    // 0 means moving towards left, 1 means moving towards right
    private float speedDirection = 0;
    public float moveSpeed = 0.5f;

    public List<GameObject> leftBricks = new List<GameObject>();
    public List<GameObject> disabledBricksLeft = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (disabledBricksCountLeft > 0)
        {
            foreach (GameObject go in leftBricks)
            {
                if (!go.activeSelf && !disabledBricksLeft.Contains(go))
                {
                    disabledBricksLeft.Add(go);
                }
            }
        }

        if (disabledBricksCountLeft < leftBricks.Count)
        {
            if (transform.position.x > -4.9f && speedDirection == 0)
            {
                transform.Translate(new Vector3(moveSpeed * -0.0075f, 0, 0));
            }
            else if (transform.position.x <= -4.9f && speedDirection == 0)
            {
                speedDirection = 1;
            }
            else if (transform.position.x < -3.9f && speedDirection == 1)
            {
                transform.Translate(new Vector3(moveSpeed * 0.0075f, 0, 0));
            }
            else if (transform.position.x >= -3.9f && speedDirection == 1)
            {
                speedDirection = 0;
            }
        }
    }

    public void DisabledCountIncrease()
    {
        disabledBricksCountLeft += 1;
        //Debug.Log(disabledBricksCountLeft);
    }

    public void DisabledCountDecrease()
    {
        disabledBricksCountLeft -= 1;
        //Debug.Log(disabledBricksCountLeft);
    }

    public void NewBrick()
    {
        if (disabledBricksCountLeft > 0)
        {
            //foreach (GameObject go in leftBricks)
            //{
            //    if (!go.activeSelf && !disabledBricksLeft.Contains(go))
            //    {
            //        disabledBricksLeft.Add(go);
            //    }
            //}

            int selectedBrickNumber = (int)Random.Range(0, disabledBricksCountLeft);
            disabledBricksLeft[selectedBrickNumber].SetActive(true);
            disabledBricksLeft.RemoveAt(selectedBrickNumber);
            //disabledBricksLeft.Clear();
            DisabledCountDecrease();
        }
    }
}
