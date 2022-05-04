using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickControlRight : MonoBehaviour
{
    public Transform bricksTotalController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "BallRight")
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);

            bricksTotalController.SendMessage("DisabledCountIncrease");
        }
    }
}
