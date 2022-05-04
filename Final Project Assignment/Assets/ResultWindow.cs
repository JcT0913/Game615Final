using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResultWindow : MonoBehaviour
{
    //public Transform scoreLeft;
    //public Transform scoreRight;

    private int scoreLeft;
    private int scoreRight;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowResult()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0;

        scoreLeft = gameObject.GetComponentInParent<GameObject>().GetComponentInChildren<RepositoryVisualizerLeft>().scoreLeft;
        scoreRight = gameObject.GetComponentInParent<GameObject>().GetComponentInChildren<RepositoryVisualizerRight>().scoreRight;
        Debug.Log(scoreLeft.ToString() + " " + scoreRight.ToString());

        if (scoreLeft > scoreRight)
        {
            transform.GetComponentInChildren<TextMeshProUGUI>().text = "Time Out!\r\n\r\n" + "Player 1 Wins!";
        }
        else if (scoreLeft < scoreRight)
        {
            transform.GetComponentInChildren<TextMeshProUGUI>().text = "Time Out!\r\n\r\n" + "Player 2 Wins!";
        }
        else
        {
            transform.GetComponentInChildren<TextMeshProUGUI>().text = "Time Out!\r\n\r\n" + "Draw!";
        }
    }
}
