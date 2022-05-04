using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RepositoryVisualizerRight : MonoBehaviour
{
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
            transform.GetComponent<TextMeshProUGUI>().text = "Score: " + list.Count.ToString();
        }
    }
}
