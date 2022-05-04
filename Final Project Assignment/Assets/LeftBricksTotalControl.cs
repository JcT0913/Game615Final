using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftBricksTotalControl : MonoBehaviour
{
    private float disabledBricksCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
