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
    public GameObject[] affectedLights;
    public GameObject cell;
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
            foreach (GameObject cell in affectedLights)
            {
                
                if(switchOn == true)
                {
                    cell.GetComponent<CellData>().dark = true;
                }
                else
                {
                    cell.GetComponent<CellData>().dark = false;
                }
                
              
                //dark = true;
                Debug.Log("I cant see!");
            }
        }
        if(dark == false)
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
        if(dark == true)
        {
            sR.sprite = darkSprite;
        }

        if(dark == false)
        {
            sR.sprite = lightSprite;
        }

        if(lightSwitch == true && switchOn == false)
        {
            sR.sprite = lightSwitchOnSprite;  
        }

        if(lightSwitch == true && switchOn == true)
        {
            sR.sprite = lightSwitchOffSprite;  
        }
    }
}
