using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellData : MonoBehaviour
{
    public bool dark = false;
    public bool LightSwitch = false;
    public bool SwitchOn =  false;
    public bool CharIsIn = false;
    public GameObject[] affectedLights;
    public Sprite[] sprites;
    
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        if(dark == true)
        {
            renderer.enabled = false;
        }

        if(LightSwitch == true)
        {
            foreach (GameObject cell in affectedLights)
            {
                setBrightness();
            }
        }
    }

    /*void OnCollisionEnter2d(Collider2D other)
    {
        if(LightSwitch == true && SwitchOn == false)
        {
            foreach (GameObject cell in affectedLights)
            {
                setBrightness();
            }
        }
        if(LightSwitch == true && SwitchOn == true)
        {
            foreach (GameObject cell in affectedLights)
            {
                setBrightness();
            }
        }

    }*/

    void setBrightness()
    {
        dark = true;
        
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
