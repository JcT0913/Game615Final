using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RepositoryVisualizerLeft : MonoBehaviour
{
    public int scoreLeft;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateRepositoryDisplay();
    }

    public void UpdateRepositoryDisplay()
    {
        foreach (string key in BallMovementLeft.repositoryDictLeft.Keys)
        {
            List<Transform> list;
            BallMovementLeft.repositoryDictLeft.TryGetValue("Brick", out list);
            scoreLeft = list.Count;
            transform.GetComponent<TextMeshProUGUI>().text = "Score: " + list.Count.ToString();
        }
    }
}
