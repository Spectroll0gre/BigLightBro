using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellData : MonoBehaviour
{

    public Sprite lightSprite; 
    public Sprite darkSprite;
    public Sprite lightSwitchOnSprite;  
    public Sprite lightSwitchOffSprite;  
    public bool dark = false;
    public bool lightSwitch = false;
    public bool switchOn =  false;
    public CellData[] affectedLights;
    public TimerUi timerUI;
    private SpriteRenderer sR;
    public int FuckUp = 1;
    //public GameObject cell;
    
    // Start is called before the first frame update
    void Start()
    {
        sR = GetComponent<SpriteRenderer>();
        //timerUI = GetComponent<TimerUi>();
        timerUI = GameObject.Find("Canvas").GetComponent<TimerUi>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("ouch");
        if(lightSwitch == true)
        {
            switchOn = !switchOn;
            print("hello");
            LightFlip();
        }
        if(!dark)
        {
            print(FuckUp);
            timerUI.LoseLife(FuckUp);
        }

        /*if(lightSwitch == true && switchOn == true)
        {
            foreach (GameObject cell in affectedLights)
            {
                setBrightness();
            }
        }*/

    }  

    // Update is called once per frame
    void Update()
    {
        DarkChange();

        

        if (lightSwitch == true && switchOn == false)
        {
            print(lightSwitch);
            sR.sprite = lightSwitchOnSprite;  
        }

        if(lightSwitch == true && switchOn == true)
        {
            sR.sprite = lightSwitchOffSprite;  
        }
    }

    public void LightFlip()
    {
        foreach (CellData cell in affectedLights)
        {
            cell.dark = !cell.dark;
            DarkChange();
        }
    }   
    
    public void DarkChange()
    {
        if (dark == true)
        {
            sR.sprite = darkSprite;
        }

        if (dark == false)
        {
            sR.sprite = lightSprite;
        }
        //dark = true;
        //Debug.Log("I cant see!");
    }
}
