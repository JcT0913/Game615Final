using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RepositoryVisualizerRight : MonoBehaviour
{
    public int scoreRight;

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
        foreach (string key in BallMovementRight.repositoryDictRight.Keys)
        {
            List<Transform> list;
            BallMovementRight.repositoryDictRight.TryGetValue("Brick", out list);
            scoreRight = list.Count;
            transform.GetComponent<TextMeshProUGUI>().text = "Score: " + list.Count.ToString();
        }
    }
}
