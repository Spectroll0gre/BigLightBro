using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneLoader : MonoBehaviour
{
    public void PlayGame()
   {
        print("button");
        SceneManager.LoadScene("Level1");
   }

   public void QuitGame()
   {
        Application.Quit();
        Debug.Log("quit");
   }
}
