using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButton()
    {
        Debug.Log("Play Button Pressed");
        EditorSceneManager.LoadScene(2);
    }

    public void ControlButton()
    {
        Debug.Log("Control Button Pressed");
        EditorSceneManager.LoadScene(1);
    }

    public void ExitButton()
    {
        Debug.Log("Exit Button Pressed");
        Application.Quit();
    }

}
