using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellData : MonoBehaviour
{

    public Sprite lightSprite; 
    public Sprite darkSprite;
    public Sprite lightSwitchOnSprite;  

    public Sprite lightSwitchOffSprite;  

    //private SpriteRenderer renderer;


    public bool dark = false;
    public bool lightSwitch = false;
    public bool switchOn =  false;
    public bool charIsIn = false;
    public string darkMode;
    public GameObject[] affectedLights;
    public Sprite[] sprites;
    public GameObject cell;
    
    private SpriteRenderer sR;
    //public GameObject cell;
    
    // Start is called before the first frame update
    void Start()
    {
        sR = GetComponent<SpriteRenderer>();
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
