using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneLoader : MonoBehaviour
{
    public KeyCode quitKey = KeyCode.Escape;

    public void PlayGame()
    {
        print("button");
        SceneManager.LoadScene("Level1");
    }

    void Update()
    {
        if (Input.GetKeyDown(quitKey))
        {
            // Call your QuitGame function here
            QuitGame();
        }
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
