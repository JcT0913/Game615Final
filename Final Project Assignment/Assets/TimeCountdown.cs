using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeCountdown : MonoBehaviour
{
    public float timeRemainedInSeconds = 90;
    private bool timeRunning = false;
    public GameObject resultWindow;

    GameObject intoPrefab;

    // Start is called before the first frame update
    void Start()
    {
        timeRunning = true;

        //intoPrefab = Instantiate(resultWindow) as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        TimeVisualizer();

        if (timeRunning && timeRemainedInSeconds > 0)
        {
            timeRemainedInSeconds -= Time.deltaTime;
        }
        else
        {
            timeRemainedInSeconds = 0;
            timeRunning = false;
            resultWindow.SendMessage("ShowResult");
            //GameObject.Find("Result").SendMessage("ShowResult");
        }
    }

    public void TimeVisualizer()
    {
        float minute = Mathf.FloorToInt(timeRemainedInSeconds / 60);
        float second = Mathf.FloorToInt(timeRemainedInSeconds % 60);

        transform.GetComponent<TextMeshProUGUI>().text = minute.ToString() + ": " + second.ToString();
    }
}
