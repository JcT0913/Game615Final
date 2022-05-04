using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RepositoryVisualizerLeft : MonoBehaviour
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
        foreach (string key in BallMovementLeft.repositoryDictLeft.Keys)
        {
            List<Transform> list;
            BallMovementLeft.repositoryDictLeft.TryGetValue("Brick", out list);
            transform.GetComponent<TextMeshProUGUI>().text = "Score: " + list.Count.ToString();
        }
    }
}
