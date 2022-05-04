using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class ControlPageButtonsScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGameButton()
    {
        Debug.Log("Start Game Button Pressed");
        EditorSceneManager.LoadScene(2);
    }

    public void BackToMenuButton()
    {
        Debug.Log("Back To Menu Button Pressed");
        EditorSceneManager.LoadScene(0);
    }
}
