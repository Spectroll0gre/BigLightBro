using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TimerUi : MonoBehaviour
{

    public TMP_Text TimerText;
    public int TimerINT = 5;
    public int FuckUp;

    // Start is called before the first frame update
    void Start()
    {
        //Setting the initial Timer
       UpdateTimerText(); 
    }

    public void UpdateTimerText()
    {
        TimerText.text = TimerINT.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoseLife(int FuckUp)
    {
        TimerINT -= FuckUp;
        UpdateTimerText();


        if(TimerINT <= 0)
        {       
            ResetScene();
        }    
    }

    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
