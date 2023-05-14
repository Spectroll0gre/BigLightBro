using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellSoundEffect : MonoBehaviour
{
    public AudioClip switchFX;
    public AudioClip switchOffFX;
    public AudioClip lightFX;
    public AudioClip darkFX;
    public AudioSource audioSource;
    public CellData cell;

    void Start() 
    {
        this.audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        cell = this.gameObject.GetComponent<CellData>();
        if (cell.dark) 
        {
            audioSource.clip = darkFX;
        } else
        {
            audioSource.clip = lightFX;
        }
        if (cell.lightSwitch && cell.switchOn == false)
        {
            audioSource.clip = switchFX;
        }
        if (cell.lightSwitch && cell.switchOn == true)
        {
            audioSource.clip = switchOffFX;
        }
        audioSource.Play();
    }

}
