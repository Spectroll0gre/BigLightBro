using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerUi : MonoBehaviour
{

    public TMP_Text TimerText;
    public int TimerINT = 5;
    public int FuckUp = 1;
    public bool dead;  //gameover state
    // Start is called before the first frame update
    void Start()
    {
        //Setting the initial Timer
       UpdateTimerText(); 
    }

    public void UpdateTimerText()
    {
        TimerText.text = "FireWalls: " + TimerINT.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void loseLife(int FuckUp)
    {
        TimerINT -= FuckUp;
        //take life int down 1 
    }
}