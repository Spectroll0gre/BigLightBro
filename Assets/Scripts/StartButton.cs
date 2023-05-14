using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
   public void PlayGame()
   {
        SceneManager.LoadScene("Level1");
   }

   public void QuitGame()
   {
        Application.Quit();
   }
}
